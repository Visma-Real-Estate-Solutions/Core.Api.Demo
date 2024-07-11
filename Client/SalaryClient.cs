using CoreDemo.Models.Enums;
using CoreDemo.Models.Salary;

using Newtonsoft.Json;

namespace CoreDemo.Client;

public class SalaryClient
{
    // Note: Not all customers use the built-in salary system in Core.

    private HttpClient HttpClient { get; }
    public SalaryClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public async Task<List<CommissionSharingDto>> GetCommissionSharingForCase(int caseId, CommissionSharingType type)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Salaries/Cases/{caseId}/CommissionSharing/Type/{type}");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Call successful!" + response.StatusCode);

                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<List<CommissionSharingDto>>(result);

                Console.WriteLine($"Commission sharing: {resultContent?.Count} items found.");

                if (resultContent != null) return resultContent;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<CommissionSharingDto>().ToList();
    }

}
