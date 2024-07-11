using System.Text;

namespace CoreDemo.MessageHandlers;

public class CoreMessageHandler : DelegatingHandler
{
    // In this file you can add overrides to your Client's HTTP requests.

    // Example:
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.Content != null && !(request.Content is MultipartFormDataContent))
        {
            var content = await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            request.Content = new StringContent(content, Encoding.UTF8, "application/json");
        }

        var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        return response;
    }
}
