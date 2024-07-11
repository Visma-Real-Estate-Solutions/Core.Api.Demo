using CoreDemo.Models;
using Newtonsoft.Json;

namespace CoreDemo.Client;

public class UsersClient
{
    private HttpClient HttpClient { get; }

    public UsersClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    // Get the active broker company id of a specific entity base, for example a user.
    public async Task<int> GetActiveBrokerCompanyId(int entityBaseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"User/EntityBaseActiveBrokerCompanyId/{entityBaseId}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<TypeResult<int>>(responseContent);
                Console.WriteLine("Active Broker Company Id: " + result?.Value);

                return result?.Value ?? 0;
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return 0;
    }
}
