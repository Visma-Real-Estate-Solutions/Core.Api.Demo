using System.Net.Http.Json;

using CoreDemo.Models;
using CoreDemo.Models.Enums;
using CoreDemo.Models.Public;
using CoreDemo.Models.Requests;

using Newtonsoft.Json;

namespace CoreDemo.Client;

public class PublicClient
{
    private readonly HttpClient _httpClient;

    public PublicClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PublicPropertyInformationDto> GetPublicPropertyInformation(string caseGuid)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"/flow/api/Public/Properties/{caseGuid}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("GetPublicPropertyInformation call successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var deserialized = JsonConvert.DeserializeObject<PublicPropertyInformationDto>(result);
                if (deserialized != null)
                {
                    Console.WriteLine(deserialized.Address);
                    return deserialized;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return new PublicPropertyInformationDto();
    }

    // Create Stakeholders
    // Ref: https://visma-real-estate-solutions.github.io/core-documentation/common#create-stakeholders

    // 1. Get a list of valid processing basis
    // All active processing bases can be retrieved by calling the following method:
    public async Task<List<ProcessingBasisDto>> GetActiveProcessingBases()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"/flow/api/ProcessingBases/Newest");
        request.Headers.Add("Accept", "application/json");
        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("GetActiveBasis call successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var deserialized = JsonConvert.DeserializeObject<List<ProcessingBasisDto>>(result);
                if (deserialized != null)
                {
                    Console.WriteLine(deserialized.FirstOrDefault()?.Id);
                    return deserialized;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<ProcessingBasisDto>().ToList();
    }

    // If you know the category and type you can use the category-specific method:
    public async Task<List<ProcessingBasisDto>> GetProcessingBasesByType(ProcessingBasisCategoryType processingBasisCategoryType)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"/flow/api/ProcessingBases/{processingBasisCategoryType}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("GetProcessingBasesByType call successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var deseralize = JsonConvert.DeserializeObject<List<ProcessingBasisDto>>(result);
                if (deseralize != null) Console.WriteLine(deseralize.FirstOrDefault()?.Id);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<ProcessingBasisDto>().ToList();
    }

    // Here is an example for getting a list of showing and manual consents for a specific property:
    public async Task<List<ProcessingBasisDto>> GetProcessingBasesForProperty()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"/flow/api/ProcessingBases/SpecificCase?displayTypes=Showing&displayTypes=Manual");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("GetProcessingBasesForProperty call successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var deseralize = JsonConvert.DeserializeObject<List<ProcessingBasisDto>>(result);
                if (deseralize != null) Console.WriteLine(deseralize.FirstOrDefault()?.Id);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<ProcessingBasisDto>().ToList();
    }

    // 2. Post information to the public integrator endpoint
    public async Task<TypeResult<int>> CreateStakeholder(string caseGuid, AnonymousCreateStakeholderRequest anonymousCreateStakeholderRequest)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, $"/flow/api/Public/Cases/{caseGuid}/Stakeholders");
        request.Headers.Add("Accept", "application/json");
        request.Content = JsonContent.Create(anonymousCreateStakeholderRequest);

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("CreateStakeholder call successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var deseralize = JsonConvert.DeserializeObject<TypeResult<int>>(result);
                if (deseralize != null)
                {
                    Console.WriteLine(deseralize.Value);
                    return deseralize;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return new TypeResult<int>();
    }

    // Send Salgsoppgave
    public async Task OrderBrochure(string caseGuid, OrderBrochureRequest orderBrochureRequest)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, $"/flow/api/Public/Properties/{caseGuid}/OrderBrochure");
        request.Headers.Add("Accept", "application/json");
        request.Content = JsonContent.Create(orderBrochureRequest);

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("OrderBrochure call successful!" + response.StatusCode);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}
