using CoreDemo.Models.Enums;
using System.Text;

using CoreDemo.Models.Case;
using CoreDemo.Models.Requests;

using Newtonsoft.Json;

namespace CoreDemo.Client;

public class CasesClient
{
    private HttpClient HttpClient { get; }
    public CasesClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public async Task<FolderItemDto> GetUniqueDocumentsFolder(int caseBaseId, UniqueFolderType uniqueType)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Cases/{caseBaseId}/Directory");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get case directory successful! " + response.StatusCode);

                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<List<FolderItemDto>>(result);

                // Multiple folders can have UniqueFolderType.Images, and multiple folder can share the name "Bilder".
                var uniqueFolder = resultContent?.Where(x => x.UniqueFolderType == uniqueType && x.Name == "Bilder").FirstOrDefault();

                if (uniqueFolder != null) return uniqueFolder;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return new FolderItemDto();
    }

    public async Task<List<DirectoryItemDto>> GetCaseFilesDirectory(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Cases/{caseId}/Directory");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get case directory successful! " + response.StatusCode);

                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<List<DirectoryItemDto>>(result);

                var directoryNames = resultContent?.Select(x => x.Name).ToList();

                if (directoryNames != null) Console.WriteLine(string.Join(", ", directoryNames));
                if (resultContent != null) return resultContent;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<DirectoryItemDto>().ToList();
    }

    public async Task<DirectoryItemDto> GetOrCreateNewFolder(int caseId, string folderName)
    {
        var type = DirectoryItemType.Folder.ToString();

        var createFolderReq = new CreateFolderRequest
        {
            Name = folderName,
            Type = type
        };

        var request = new HttpRequestMessage(HttpMethod.Post, $"Cases/{caseId}/Directory");
        request.Headers.Add("Accept", "application/json");
        request.Content = new StringContent(JsonConvert.SerializeObject(createFolderReq), Encoding.UTF8, "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Create new folder(directory) successful!" + response.StatusCode);

                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<DirectoryItemDto>(result);

                if (resultContent != null)
                {
                    Console.WriteLine(resultContent.Id);
                    return resultContent;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return new DirectoryItemDto();
    }

    public async Task<object> GetCaseFile(int caseId, string fileGuid)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Cases/{caseId}/Files/{fileGuid}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get file successful!" + response.StatusCode);
                var stream = await response.Content.ReadAsStreamAsync();
                var file = await GetDeserializedObject(stream);
                return file;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return new object();
    }

    public async Task<HttpResponseMessage> GetCaseImage(int caseId, string fileGuid, string imageSize, System.Net.Http.Headers.EntityTagHeaderValue? etag = null)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Cases/{caseId}/Image/{fileGuid}/{imageSize}/");
        request.Headers.Add("Accept", "application/json");

        if (etag != null)
        {
            request.Headers.IfNoneMatch.ParseAdd(etag.Tag);
        }

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get image successful! " + response.StatusCode);
                // deserialize json as ContactSearchModelDto
                var stream = await response.Content.ReadAsStreamAsync(); //.Content.ReadFromJsonAsync<List<ContactSearchModelDto>>();
                var image = await GetDeserializedObject(stream);
            }

            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<FileTagDto>> GetFileTags()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"FileTags/");
        request.Headers.Add("Accept", "application/json");
        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get file tags successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<List<FileTagDto>>(result);

                return resultContent ?? new List<FileTagDto>();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Enumerable.Empty<FileTagDto>().ToList();
    }

    public async Task<string> UploadCaseFile(int caseId, Guid directoryGuid, List<int> fileTagIds, string filePath, string uploadFileName)
    {
        var type = DirectoryItemType.File.ToString();
        Console.WriteLine(filePath);
        var uploadReq = new UploadFileRequest
        {
            Name = uploadFileName,
            TagIds = fileTagIds
        };

        MultipartFormDataContent uploadForm = new MultipartFormDataContent();
        var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        uploadForm.Add(new StreamContent(fileStream), uploadFileName, uploadFileName); // Add the file you want to upload
        uploadForm.Add(new StringContent(JsonConvert.SerializeObject(uploadReq)), "request"); // Add request, includes tags and more (See UploadFileRequest)

        // Note: Supports creation of multiple files in one request.
        var request = new HttpRequestMessage(HttpMethod.Post, $"Cases/{caseId}/Directory/{directoryGuid}/{type}/");
        request.Headers.Add("Accept", "application/json");
        request.Content = uploadForm;

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Upload file successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<List<FileDto>>(result);

                var fileNames = resultContent?.Select(x => x.Name).ToList();

                if (fileNames != null)
                {
                    Console.WriteLine(string.Join(", ", fileNames));
                    return fileNames.FirstOrDefault() ?? string.Empty;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("error uploading file");
            Console.WriteLine(e);
            throw;
        }

        return string.Empty;
    }

    public async Task<string> UploadImagesToCase(int caseId, List<string> imagePaths, bool export)
    {
        var category = MediaCategory.FloorPlan.ToString();

        var uploadForm = new MultipartFormDataContent();
        foreach (var image in imagePaths)
        {
            var fileStream = new FileStream(image, FileMode.Open, FileAccess.Read);
            var streamContent = new StreamContent(fileStream); // Add the file you want to upload
            streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

            uploadForm.Add(streamContent, Path.GetFileName(image), Path.GetFileName(image));
        }

        // Note: Supports creation of multiple files in one request.
        var request = new HttpRequestMessage(HttpMethod.Post, $"Cases/Images?caseIds={caseId}&category={category}&export={export}");
        request.Headers.Add("Accept", "application/json");
        request.Content = uploadForm;

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Upload images successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<List<FileDto>>(result);

                var imageNames = resultContent?.Select(x => x.Name).ToList();

                if (imageNames?.Count > 0)
                {
                    Console.WriteLine(string.Join(", ", imageNames));
                    return imageNames.First();
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("error uploading file");
            Console.WriteLine(e);
            throw;
        }

        return string.Empty;
    }

    #region Publications
    public async Task<List<int>> GetActivePublications(PublicationProviderType type)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"v2/Publications/ActivePublications/{type}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get active publications successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<List<int>>(result);

                return resultContent ?? new List<int>();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return Enumerable.Empty<int>().ToList();
    }

    #endregion

    #region Document signatures

    public async Task<List<DocumentSigningDto>> GetCaseDocumentSignatures(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"DocumentSignatures/cases/{caseId}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get document signatures successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<List<DocumentSigningDto>>(result);

                return resultContent ?? new List<DocumentSigningDto>();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return Enumerable.Empty<DocumentSigningDto>().ToList();
    }

    #endregion

    #region Various Case information

    public async Task<ResidenceDto> GetResidence(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Properties/{caseId}/Residence");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get residence successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<ResidenceDto>(result);

                return resultContent ?? new ResidenceDto();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return new ResidenceDto();
    }

    public async Task<BuildingDto> GetBuilding(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Properties/{caseId}/Building");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get building successful!" + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<BuildingDto>(result);

                return resultContent ?? new BuildingDto();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        return new BuildingDto();
    }

    public async Task<PropertyInformationDto> GetPropertyInformation(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Properties/{caseId}/Information");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get property information successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<PropertyInformationDto>(result);

                return resultContent ?? new PropertyInformationDto();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return new PropertyInformationDto();
    }

    public async Task<FacilitiesDto> GetFacilities(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Properties/{caseId}/Facilities");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get facilities successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<FacilitiesDto>(result);

                return resultContent ?? new FacilitiesDto();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return new FacilitiesDto();
    }

    public async Task<LandLotLeaseInformationDto> GetLandLotLeaseInformation(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Cases/{caseId}/LandLotLeaseInformation");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get land lot lease information successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<LandLotLeaseInformationDto>(result);

                return resultContent ?? new LandLotLeaseInformationDto();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return new LandLotLeaseInformationDto();
    }

    public async Task<PropertyConditionsDto> GetPropertyConditions(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Conditions/Properties/{caseId}");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get property conditions successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<PropertyConditionsDto>(result);

                return resultContent ?? new PropertyConditionsDto();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return new PropertyConditionsDto();
    }

    public async Task<PublicTaxesDto> GetPublicTaxes(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Properties/{caseId}/PublicTaxes");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get public taxes successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<PublicTaxesDto>(result);

                return resultContent ?? new PublicTaxesDto();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return new PublicTaxesDto();
    }

    public async Task<CommonConditionsDto> GetCommonConditions(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Properties/{caseId}/CommonConditions");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get common conditions successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<CommonConditionsDto>(result);

                return resultContent ?? new CommonConditionsDto();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return new CommonConditionsDto();
    }

    public async Task<AddressDto> GetCaseAddress(int caseId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"Cases/{caseId}/Address");
        request.Headers.Add("Accept", "application/json");

        try
        {
            var response = await HttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Get case address successful! " + response.StatusCode);
                var result = await response.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<AddressDto>(result);

                return resultContent ?? new AddressDto();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return new AddressDto();
    }

    #endregion

    private static async Task<string> GetDeserializedObject(Stream stream)
    {
        using (var reader = new StreamReader(stream))
        {
            return await reader.ReadToEndAsync();
        }
    }
}
