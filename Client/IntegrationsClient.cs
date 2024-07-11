using System.Text;

using CoreDemo.Models.Enums;
using CoreDemo.Models.Integrations;
using CoreDemo.Models.Requests;

using Newtonsoft.Json;

namespace CoreDemo.Client;

public class IntegrationsClient
{

    private HttpClient HttpClient { get; }

    public IntegrationsClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public async Task<List<BankTransferTypeDto>> GetBankTransferTypes(int caseId, EntryDefinitionType entryDefinitionType, string? brokerCompanyOrgNum = null)
    {
        var url = $"Integrations/Invoicing/Cases/{caseId}/EntryDefinitionTypes/{entryDefinitionType}/BankTransferTypes";
        if (brokerCompanyOrgNum != null)
        {
            url += $"?brokerCompanyOrgNum={brokerCompanyOrgNum}";
        }

        var response = await HttpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<IEnumerable<BankTransferTypeDto>>(content)?.ToList();

        if (result == null)
        {
            Console.WriteLine("No bank transfer types found");
            return Enumerable.Empty<BankTransferTypeDto>().ToList();
        }

        Console.WriteLine($"Bank transfer types for case {caseId} and entry definition type {entryDefinitionType} retrieved successfully");
        Console.WriteLine(result.FirstOrDefault()?.Name);

        return result;
    }

    public async Task<BankTransferDto> CreateBankTransfer(int caseId, BankTransferRequest request)
    {
        var url = $"Integrations/Invoicing/Cases/{caseId}/BankTransfers";
        var json = JsonConvert.SerializeObject(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await HttpClient.PostAsync(url, content);

        if (response.IsSuccessStatusCode)
        {

            var responseContent = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BankTransferDto>(responseContent);

            Console.WriteLine($"Bank transfer created successfully with id {result?.Id}");
            return result ?? new BankTransferDto();
        }
        Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        return new BankTransferDto();
    }

    public async Task<BankTransferDto> UpdateBankTransfer(int caseId, int bankTransferId, BankTransferRequest request)
    {
        var url = $"Integrations/Invoicing/Cases/{caseId}/BankTransfers/{bankTransferId}";
        var json = JsonConvert.SerializeObject(request, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        });
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await HttpClient.PatchAsync(url, content);

        if (response.IsSuccessStatusCode)
        {

            var responseContent = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BankTransferDto>(responseContent);

            Console.WriteLine($"Bank transfer updated successfully with id {result?.Id}");
            Console.WriteLine($"Amount: {result?.Amount}");
            return result ?? new BankTransferDto();
        }
        Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        return new BankTransferDto();
    }
}
