using System.Net;

using CoreDemo;
using CoreDemo.Client;
using CoreDemo.MessageHandlers;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Polly;
using Polly.Extensions.Http;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Our code, in the middle of the flow.");


var builder = Host.CreateApplicationBuilder(args);

var configuration = builder.Configuration;
configuration.AddUserSecrets<global::Program>();

builder.Services.AddAccessTokenManagement(options =>
{
    options.Client.Clients.Add("Core", new IdentityModel.Client.ClientCredentialsTokenRequest
    {
        Address = configuration["CoreConfiguration:Host"] +
                  configuration["CoreConfiguration:AuthUri"],
        ClientId = configuration["CoreConfiguration:ClientId"],
        ClientSecret = configuration["CoreConfiguration:ClientSecret"],
        ClientCredentialStyle = IdentityModel.Client.ClientCredentialStyle.PostBody,
        GrantType = "client_credentials",
    });

});

builder.Services
    .AddHttpClient<CoreClient>(
        httpClient =>
        {
            httpClient.BaseAddress = new Uri(string.Concat(configuration["CoreConfiguration:Host"] + "/api/"));
            httpClient.DefaultRequestHeaders.ExpectContinue = false;
            httpClient.Timeout = TimeSpan.FromSeconds(20);
        })
    .AddHttpMessageHandler<CoreMessageHandler>()
    .AddClientAccessTokenHandler("Core")
    .SetHandlerLifetime(TimeSpan.FromSeconds(5))
    .AddPolicyHandler(GetRetryPolicy())
    .AddPolicyHandler(GetAuthorizationPermissionPolicy())
    .AddPolicyHandler(GetThrottlingPolicy());

builder.Services.AddScoped<CoreApiDemo>();
builder.Services.AddScoped<CoreMessageHandler>();
var host = builder.Build();

var service = host.Services.GetService<CoreApiDemo>();

if (service == null)
    throw new Exception("Service is not properly defined. Make sure you have properly set configurations.");
await service.Run();

static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
    => HttpPolicyExtensions
        .HandleTransientHttpError()
        .OrResult(static msg => !msg.IsSuccessStatusCode && msg.StatusCode != HttpStatusCode.Forbidden)
        .WaitAndRetryAsync(1, static retryAttempt => TimeSpan.FromSeconds(2 * retryAttempt));

// When the request is forbidden, we will also return missing permissions in the body.
static AsyncPolicy<HttpResponseMessage> GetAuthorizationPermissionPolicy()
    => HttpPolicyExtensions
        .HandleTransientHttpError()
        .OrResult(static msg => msg.StatusCode == HttpStatusCode.Forbidden)
        .FallbackAsync(fallbackValue: new HttpResponseMessage(HttpStatusCode.Forbidden),
            async static (msg, _) =>
        {
            // Get body from msg.
            var body = await msg.Result.Content.ReadAsStringAsync();
            Console.WriteLine("Authorization failed. Please verify your api-user har the required permissions:");
            Console.WriteLine(body);
        });

static IAsyncPolicy<HttpResponseMessage> GetThrottlingPolicy()
    => HttpPolicyExtensions
        .HandleTransientHttpError()
        .OrResult(static msg => msg.StatusCode == HttpStatusCode.TooManyRequests)
        .FallbackAsync(fallbackValue: new HttpResponseMessage(HttpStatusCode.TooManyRequests), (msg, _) =>
            {
                var headers = msg.Result.Headers;
                Console.WriteLine("Throttling detected. Please wait before trying again.");
                Console.WriteLine($"You request was delayed for ms: {headers.GetValues("X-RateLimit-Delayed-By-Milliseconds").FirstOrDefault()}");
                Console.WriteLine($"Number of requests allowed within time window: {headers.GetValues("X-RateLimit-Limit").FirstOrDefault()}");
                Console.WriteLine($"Number of requests used within current time window: {headers.GetValues("X-RateLimit-Remaining").FirstOrDefault()}");
                Console.WriteLine($"Current time window end: {headers.GetValues("X-RateLimit-Reset").FirstOrDefault()}");

                // Handle your issue accordingly by waiting for the reset time or end in failure.
                // If unsure, wait 3.5 seconds before trying again.
                return Task.CompletedTask;
            });
