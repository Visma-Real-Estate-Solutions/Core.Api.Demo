using CoreDemo.Models.General;

using Newtonsoft.Json;

namespace CoreDemo.Client;

public class GeneralClient
{

    private HttpClient HttpClient { get; }

    public GeneralClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public async Task<IEnumerable<RecentlyModifiedCaseDto>> GetRecentlyModifiedCases(DateTime fromDate)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Integrations/RecentlyModified/Cases?fromDate={fromDate}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get recently modified cases successful! " + response.StatusCode);

                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<List<RecentlyModifiedCaseDto>>(result) ?? new List<RecentlyModifiedCaseDto>();

                Console.WriteLine($"A total of {resultContent.Count} cases were changed since {fromDate}");

                return resultContent;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return Enumerable.Empty<RecentlyModifiedCaseDto>();
    }

    public async Task<IEnumerable<RecentlyModifiedContactDto>> GetRecentlyModifiedContacts(DateTime fromDate)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Integrations/RecentlyModified/Contacts?fromDate={fromDate}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get recently modified contacts successful! " + response.StatusCode);

                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<List<RecentlyModifiedContactDto>>(result) ?? new List<RecentlyModifiedContactDto>();

                Console.WriteLine($"A total of {resultContent.Count} contacts were changed since {fromDate}");

                return resultContent;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return Enumerable.Empty<RecentlyModifiedContactDto>();
    }
}
