using CoreDemo.Models.Economics;
using CoreDemo.Models.Enums;

using Newtonsoft.Json;

namespace CoreDemo.Client;

public class EconomicsClient
{

    private readonly HttpClient _httpClient;

    public EconomicsClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<EntryDefinitionDto>> GetEntryDefinitionsByCaseCategory(CaseCategoryType caseCategory)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Economics/{caseCategory}/EntryDefinitions");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("GetExternalEntries call successful!" + response.StatusCode);
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<EntryDefinitionDto>>(responseString) ?? new List<EntryDefinitionDto>();

                Console.WriteLine("External entries found: " + result.Count);
                return result;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return Enumerable.Empty<EntryDefinitionDto>().ToList();
    }

    public async Task<List<EntryDefinitionAdminDto>> GetExtendedEntryDefinitions(bool includeDeleted)
    {
        // includeDeleted is not a required parameter and defaults to false if not provided
        var request = new HttpRequestMessage(HttpMethod.Get, $"Economics/ExtendedEntryDefinitions?includeDeleted={includeDeleted}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("GetExtendedEntryDefinitions call successful!" + response.StatusCode);
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<EntryDefinitionAdminDto>>(responseString) ?? new List<EntryDefinitionAdminDto>();

                Console.WriteLine("External entries found: " + result.Count);
                return result;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return Enumerable.Empty<EntryDefinitionAdminDto>().ToList();
    }
}
