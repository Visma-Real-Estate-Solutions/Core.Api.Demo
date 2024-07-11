using CoreDemo.Models;
using CoreDemo.Models.Activities;
using CoreDemo.Models.Contacts;

using Newtonsoft.Json;

namespace CoreDemo.Client;

public class ActivitiesClient
{
    private HttpClient HttpClient { get; }

    public ActivitiesClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public async Task<IEnumerable<ActivityModelDto>> GetActivities(string odataQuery)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Activities{odataQuery}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<InlineCountDto<ActivityModelDto>>(responseContent);
                Console.WriteLine(result?.Count);
                if (result != null)
                    return result.Results;
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<ActivityModelDto>();
    }

    public async Task<List<ActivityParticipantModelDto>> GetParticipantsForActivity(int activityId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Activities/{activityId}/ParticipantsV2");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ActivityParticipantModelDto>>(responseContent);
                Console.WriteLine(result?.Count);
                if (result != null)
                    return result;
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<ActivityParticipantModelDto>().ToList();
    }

    public async Task<List<ContactDto>> GetContactsForActivity(int activityId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Activities/{activityId}/Participants");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ContactDto>>(responseContent);
                Console.WriteLine(result?.Count);
                if (result != null)
                    return result;
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<ContactDto>().ToList();
    }

    public async Task<List<ActivityModelDto>> GetActivitiesForContact(int contactId, DateTime fromDate, DateTime toDate)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Activities/Contacts/{contactId}?fromDate={fromDate:yyyy-MM-ddTHH:mm:ss.fffZ}&toDate={toDate:yyyy-MM-ddTHH:mm:ss.fffZ}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ActivityModelDto>>(responseContent);
                Console.WriteLine(result?.Count);
                if (result != null)
                    return result;
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<ActivityModelDto>().ToList();
    }
}
