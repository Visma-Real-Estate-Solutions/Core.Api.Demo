using System.Net.Http.Json;
using System.Text;

using CoreDemo.Helpers;
using CoreDemo.Models;
using CoreDemo.Models.Contacts;
using CoreDemo.Models.Requests;

using Newtonsoft.Json;

namespace CoreDemo.Client;

public class ContactsClient
{
    private HttpClient HttpClient { get; }

    public ContactsClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public async Task<ContactDto> GetContactById(int id)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Contacts/{id}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ContactDto>(responseContent);
                Console.WriteLine(result?.Name);
                Console.WriteLine(result?.Type);
                return result ?? await Task.FromResult(new ContactDto());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return new ContactDto();
    }

    public async Task<PersonDto> GetPersonById(int id)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Persons/{id}");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<PersonDto>(responseContent);
                Console.WriteLine(result?.Name);
                Console.WriteLine(result?.BirthDate);
                if (result != null) return result;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return new PersonDto();
    }

    public async Task<EmployeeDto> GetEmployeeById(int id)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Employees/{id}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Call successful!" + response.StatusCode);
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<EmployeeDto>(responseContent);
                if (result == null)
                {
                    Console.WriteLine("No result found");
                    return new EmployeeDto();
                }

                Console.WriteLine(result.Name);
                Console.WriteLine(result.Title);
                return result;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return new EmployeeDto();
    }

    public async Task<IEnumerable<ContactDto>> GetContacts(string odataQuery)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Contacts{odataQuery}");
        request.Headers.Add("Accept", "application/json;odata.metadata=minimal");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();

                // Note that the response for this endpoint is a bit different from the others, as it includes page-count
                if (!odataQuery.Contains("count=true"))
                   return JsonConvert.DeserializeObject<IEnumerable<ContactDto>>(responseContent) ?? new List<ContactDto>();

                // If we requested a page-count, we need to deserialize the response differently and handle pagination
                var result = JsonConvert.DeserializeObject<InlineCountDto<ContactDto>>(responseContent);
                Console.WriteLine(result?.Count);
                if (result != null)
                {
                    var pages = OdataHelper.GetPageCount(result);
                    if (pages > 1)
                    {
                        Console.WriteLine($"Pages: {pages}");
                        // Here you can write custom logic to fetch all pages, or continue with only the first page
                    }
                    return result.Results;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return Enumerable.Empty<ContactDto>();
    }

    public async Task<IEnumerable<OfficeDto>> GetOffices(string odataQuery = "")
    {
        // var odata
        var request = new HttpRequestMessage(HttpMethod.Get, $"Offices{odataQuery}");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<IEnumerable<OfficeDto>>(responseContent) ?? new List<OfficeDto>();
                foreach (var office in result)
                {
                    Console.WriteLine(office.Name);
                    Console.WriteLine(office.OfficeNumber);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return Enumerable.Empty<OfficeDto>();
    }

    /// <summary>
    /// Contrary to the endpoint's name, this method returns the last five digits of the Social Security number.
    /// Requires Persons- and PersonIdentityNumber Read-rights.
    /// </summary>
    /// <param name="id"></param>
    /// <returns>5 last digits of the Social Security number</returns>
    public async Task<string> GetFullIdentityNumber(int id)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Persons/{id}/FullIdentityNumber");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                // content is returned with quotation marks as a json string and must be deserialized
                var result = await response.Content.ReadFromJsonAsync<string>();
                Console.WriteLine(result);
                return result ?? string.Empty;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return string.Empty;
    }

    public async Task<IEnumerable<EmployeeDto>> GetEmployeesOnOffice(int officeId, bool includeInactive = false)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Offices/{officeId}/Employees?includeInactive={includeInactive}");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<IEnumerable<EmployeeDto>>(responseContent)?.ToList() ?? new List<EmployeeDto>();
                foreach (var employee in result)
                {
                    Console.WriteLine(employee.Name);
                    Console.WriteLine(employee.Title);
                }
                return result;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return Enumerable.Empty<EmployeeDto>();
    }

    public async Task<OfficeInformationDto> GetOfficeInformation(int officeId)
    {
        // Requires OfficeAdministration (Read)
        var request = new HttpRequestMessage(HttpMethod.Get, $"Offices/{officeId}/Information");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<OfficeInformationDto>(responseContent);
                Console.WriteLine(result?.FinnPartnerId);
                if (result != null) return result;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return new OfficeInformationDto();
    }

    #region Data Processor

    // Most fields in Office, BrokerCompany and Chain regarding values and stats can be found through journals, e.g:
    // https://visma-real-estate-solutions.github.io/core-documentation/docs/frequent_integrations/data_processor.html#cache

    // Swap /Offices with /BrokerCompanies, or /Chain and officeid with chainId, or brokerCompanyId for journals from brokerCompany or the entire chain.

    public async Task<IEnumerable<CaseJournalDto>> GetCaseJournals(int officeId, DateTimeOffset fromDate, DateTimeOffset toDate)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Offices/{officeId}/CaseJournals?fromDate={fromDate:yyyy-MM-dd}&toDate={toDate:yyyy-MM-dd}");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<IEnumerable<CaseJournalDto>>(responseContent);
                if (result != null)
                {
                    Console.WriteLine(result.Count());
                    return result;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return Enumerable.Empty<CaseJournalDto>();
    }

    public async Task<IEnumerable<DepotJournalDto>> GetDepotJournals(int officeId, DateTimeOffset fromDate, DateTimeOffset toDate)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Offices/{officeId}/DepotJournals?fromDate={fromDate:yyyy-MM-dd}&toDate={toDate:yyyy-MM-dd}");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<IEnumerable<DepotJournalDto>>(responseContent);
                if (result != null)
                {
                    Console.WriteLine(result.Count());
                    return result;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return Enumerable.Empty<DepotJournalDto>();
    }

    public async Task<IEnumerable<RevenueJournalDto>> GetRevenueJournals(int officeId, DateTimeOffset fromDate, DateTimeOffset toDate)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Offices/{officeId}/RevenueJournals?fromDate={fromDate:yyyy-MM-dd}&toDate={toDate:yyyy-MM-dd}");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<IEnumerable<RevenueJournalDto>>(responseContent);
                if (result != null)
                {
                    Console.WriteLine(result.Count());
                    return result;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return Enumerable.Empty<RevenueJournalDto>();
    }

    public async Task<RevenueJournalSumDto> GetRevenueJournalsSum(int officeId, DateTimeOffset fromDate, DateTimeOffset toDate)
    {
        var request = new HttpRequestMessage(HttpMethod.Put, $"Offices/{officeId}/RevenueJournals/Sum");

        var revenueJournalSumRequest = new RevenueJournalSumRequest
        {
            FromDate = fromDate,
            ToDate = toDate
        };

        request.Content = new StringContent(JsonConvert.SerializeObject(revenueJournalSumRequest), Encoding.UTF8, "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RevenueJournalSumDto>(responseContent);
                if (result != null)
                {
                    Console.WriteLine(result);
                    return result;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        return new RevenueJournalSumDto();
    }

    public async Task<IEnumerable<SettlementJournalDto>> GetSettlementJournals(int officeId, DateTimeOffset fromDate, DateTimeOffset toDate)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Offices/{officeId}/SettlementJournals?fromDate={fromDate:yyyy-MM-dd}&toDate={toDate:yyyy-MM-dd}");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<IEnumerable<SettlementJournalDto>>(responseContent);
                if (result != null) return result;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        return Enumerable.Empty<SettlementJournalDto>();
    }

    #endregion
}
