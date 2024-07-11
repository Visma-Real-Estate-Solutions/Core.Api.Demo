using System.Text;

using CoreDemo.Models;
using CoreDemo.Models.Admin;
using CoreDemo.Models.Enums;
using CoreDemo.Models.Requests;

using Newtonsoft.Json;

namespace CoreDemo.Client;

public class AdminClient
{
    private readonly HttpClient _httpClient;

    public AdminClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    #region MarketingIntegrator

    /// <summary>
    /// Create an order as a Marketing Integrator on behalf of a customer
    /// Ref: https://visma-real-estate-solutions.github.io/core-documentation/docs/marketing-integrator/new-order-as-integrator.html
    /// </summary>
    /// <returns></returns>
    public async Task<MarketingIntegratorOrderDto> CreateOrderOnBehalfOfCustomer(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, $"MarketingIntegrators/Cases/{caseId}/CreateOrderAsIntegrator");
        request.Headers.Add("Accept", "application/json");
        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("CreateOrder call successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var deserialized = JsonConvert.DeserializeObject<MarketingIntegratorOrderDto>(result);
                if (deserialized != null)
                {
                    Console.WriteLine(deserialized.Title);
                    return deserialized;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        return new MarketingIntegratorOrderDto();
    }

    /// <summary>
    /// Set status for order
    /// https://visma-real-estate-solutions.github.io/core-documentation/docs/marketing-integrator/order-methods.html#add-integration-status-and-state
    /// </summary>
    /// <returns></returns>
    public async Task<MarketingIntegratorOrderDto> UpdateOrderState(Guid orderGuid)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, $"MarketingIntegrators/Orders/{orderGuid}/updatestate");
        request.Headers.Add("Accept", "application/json");

        var setOrderStateRequest = new MarketingIntegratorOrderStateRequest
        {
            State = MarketingIntegratorOrderStateType.Activated,
            Status = "Activated"
        };

        request.Content = new StringContent(JsonConvert.SerializeObject(setOrderStateRequest), Encoding.UTF8, "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("UpdateOrderState call successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var deserialized = JsonConvert.DeserializeObject<MarketingIntegratorOrderDto>(result);
                if (deserialized != null)
                {
                    Console.WriteLine(deserialized.Title);
                    return deserialized;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        return new MarketingIntegratorOrderDto();
    }

    /// <summary>
    /// Set metadata on an order
    /// https://visma-real-estate-solutions.github.io/core-documentation/docs/marketing-integrator/order-methods.html#update-order
    /// </summary>
    /// <returns></returns>
    public async Task<MarketingIntegratorOrderDto> UpdateOrderMetadata(Guid orderGuid)
    {
        var request = new HttpRequestMessage(HttpMethod.Patch, $"marketingintegrators/orders/{orderGuid}");
        request.Headers.Add("Accept", "application/json");

        var updateRequest = new MarketingIntegratorOrderMetadataRequest
        {
            Title = "Title",
            ActionText = "Text on order button",
            Metadata = new List<MarketingIntegratorMetadataDto>
            {
                new()
                {
                    Key = "Link to our website",
                    Value = "www.google.com"
                },
                new()
                {
                    Key = "Id of the order in our system",
                    Value = "12345"
                }
            }
        };

        request.Content = new StringContent(JsonConvert.SerializeObject(updateRequest), Encoding.UTF8, "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("UpdateOrder call successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var deserialized = JsonConvert.DeserializeObject<MarketingIntegratorOrderDto>(result);
                if (deserialized != null)
                {
                    Console.WriteLine(deserialized.Title);
                    return deserialized;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return new MarketingIntegratorOrderDto();
    }

    /// <summary>
    /// Verify FlowToken and get user information
    /// https://visma-real-estate-solutions.github.io/core-documentation/docs/marketing-integrator/order-methods.html#verify-flowtoken
    /// </summary>
    /// <returns></returns>
    public async Task<MarketingIntegratorTokenDto> VerifyFlowToken(string flowToken)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, $"MarketingIntegrators/VerifyToken");
        request.Headers.Add("Accept", "application/json");

        var tokenRequest = new MarketingIntegratorTokenRequest
        {
            Token = flowToken
        };

        request.Content = new StringContent(JsonConvert.SerializeObject(tokenRequest), Encoding.UTF8, "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("UpdateOrder call successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var deserialized = JsonConvert.DeserializeObject<MarketingIntegratorTokenDto>(result);
                if (deserialized != null)
                {
                    Console.WriteLine(deserialized.FullName);
                    return deserialized;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return new MarketingIntegratorTokenDto();
    }

    #endregion

    #region DST

    /// <summary>
    /// Is DST turned on for this case
    /// </summary>
    /// <param name="caseId"></param>
    /// <returns></returns>
    public async Task<bool> UseDynamicSaleText(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"DynamicSaleText/Cases/{caseId}/UseDynamicSaleText");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("UseDynamicSaleText call successful!" + response.StatusCode);
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<TypeResult<bool>>(responseString);

                Console.WriteLine("DST is turned on: " + result?.Value);

                return result?.Value ?? false;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return false;
    }

    /// <summary>
    /// Get all merged saletextitems on a case
    /// </summary>
    /// <param name="caseId"></param>
    /// <returns></returns>
    public async Task<List<DynamicSaleTextMergedItemDto>> GetDynamicSaleTextItems(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"DynamicSaleText/Cases/{caseId}/DynamicSaleTextItems");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("GetDynamicSaleTextItems call successful!" + response.StatusCode);
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<DynamicSaleTextMergedItemDto>>(responseString) ?? new List<DynamicSaleTextMergedItemDto>();

                Console.Write("HeaderId: " + result.FirstOrDefault()?.Id);
                //Console.WriteLine("Header: " + result?.FirstOrDefault()?.Header);

                return await Task.FromResult(result);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return Enumerable.Empty<DynamicSaleTextMergedItemDto>().ToList();
    }

    /// <summary>
    /// Returns a specified merged saletextitem on a case
    /// </summary>
    /// <param name="caseId"></param>
    /// <param name="itemId"></param>
    /// <returns></returns>
    public async Task<DynamicSaleTextMergedItemDto> GetDynamicSaleTextItem(int caseId, int itemId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"DynamicSaleText/Cases/{caseId}/DynamicSaleTextItem/{itemId}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("GetDynamicSaleTextItem call successful!" + response.StatusCode);
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<DynamicSaleTextMergedItemDto>(responseString);

                Console.WriteLine(string.IsNullOrWhiteSpace(result?.Header) ? "No header found" : result.Header);

                return result ?? await Task.FromResult(new DynamicSaleTextMergedItemDto());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return new DynamicSaleTextMergedItemDto();
    }

    #endregion

    #region External Entries
    public async Task<List<ExternalEntryDto>> GetExternalEntries(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Cases/{caseId}/ExternalEntries");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("GetExternalEntries call successful!" + response.StatusCode);
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ExternalEntryDto>>(responseString) ?? new List<ExternalEntryDto>();

                Console.WriteLine("External entries found: " + result.Count);

                return await Task.FromResult(result);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return Enumerable.Empty<ExternalEntryDto>().ToList();
    }

    public async Task<ExternalEntryDto> CreateExternalEntry(ExternalEntryRequest request)
    {
        var serialized = JsonConvert.SerializeObject(request);
        var content = new StringContent(serialized, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync("Economics/ExternalEntries", content);
        if (response.IsSuccessStatusCode)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ExternalEntryDto>(responseString);

            Console.WriteLine("External entry created: " + result?.Id);

            return result ?? new ExternalEntryDto();
        }

        return new ExternalEntryDto();
    }

    #endregion
}
