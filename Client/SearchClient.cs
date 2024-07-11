using CoreDemo.Models;
using CoreDemo.Models.Search;

using Newtonsoft.Json;

namespace CoreDemo.Client;

public class SearchClient
{
    private HttpClient HttpClient { get; }
    public SearchClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public async Task<List<ContactSearchDto>> AdvancedContactSearch(string odata)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, $"Search/AdvancedContactSearch{odata}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Call successful!" + response.StatusCode);

                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<InlineCountDto<ContactSearchDto>>(result);

                return resultContent?.Results.ToList() ?? new List<ContactSearchDto>();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<ContactSearchDto>().ToList();
    }

    public async Task<List<PropertySearchDto>> AdvancedPropertySearch(string odata)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, $"Search/AdvancedPropertySearch{odata}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Call successful!" + response.StatusCode);

                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<InlineCountDto<PropertySearchDto>>(result);

                Console.WriteLine("CaseReferralKey: " + resultContent?.Results.FirstOrDefault()?.CaseReferralKey);

                return resultContent?.Results.ToList() ?? new List<PropertySearchDto>();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<PropertySearchDto>().ToList();
    }

    public async Task<List<ProjectSearchDto>> AdvancedProjectSearch(string odata)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, $"Search/AdvancedProjectSearch{odata}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Call successful!" + response.StatusCode);

                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<InlineCountDto<ProjectSearchDto>>(result);

                Console.WriteLine("Project:" + resultContent?.Results.FirstOrDefault()?.MasterProjectName);
                return resultContent?.Results.ToList() ?? new List<ProjectSearchDto>();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<ProjectSearchDto>().ToList();
    }
}
