using CoreDemo.Helpers;
using CoreDemo.Models;
using CoreDemo.Models.Activities;
using CoreDemo.Models.Admin;
using CoreDemo.Models.Case;
using CoreDemo.Models.Contacts;
using CoreDemo.Models.Economics;
using CoreDemo.Models.Enums;
using CoreDemo.Models.General;
using CoreDemo.Models.Integrations;
using CoreDemo.Models.Public;
using CoreDemo.Models.Requests;
using CoreDemo.Models.Salary;
using CoreDemo.Models.Search;

namespace CoreDemo.Client;

public class CoreClient
{
    private HttpClient HttpClient { get; }
    private SearchClient _searchClient { get;  }
    private PublicClient _publicClient { get;  }
    private ContactsClient _contactClient { get;  }
    private EconomicsClient _economicsClient { get;  }
    private CasesClient _casesClient { get; }
    private IntegrationsClient _integrationsClient { get; }
    private GeneralClient _generalClient { get; }
    private AdminClient _adminClient { get; }
    private ActivitiesClient _activitiesClient { get; }
    private SalaryClient _salaryClient { get; }

    private UsersClient _usersClient { get; }

    public CoreClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
        _integrationsClient = new IntegrationsClient(HttpClient);
        _generalClient = new GeneralClient(HttpClient);
        _searchClient = new SearchClient(HttpClient);
        _publicClient = new PublicClient(HttpClient);
        _contactClient = new ContactsClient(HttpClient);
        _economicsClient = new EconomicsClient(HttpClient);
        _casesClient = new CasesClient(HttpClient);
        _adminClient = new AdminClient(HttpClient);
        _activitiesClient = new ActivitiesClient(HttpClient);
        _salaryClient = new SalaryClient(HttpClient);
        _usersClient = new UsersClient(HttpClient);
    }

    // Feel free to change the Odata queries to fit your needs.
    public async Task<List<ContactSearchDto>> AdvancedContactSearch()
    {
        var odata = new Odata(10, 0, "Name eq 'Test'", "Name", count: true).ToString();
        return await _searchClient.AdvancedContactSearch(odata);
    }

    public async Task<List<PropertySearchDto>> AdvancedPropertySearch()
    {
        var odata = new Odata(10, 0, "Id eq 66115", count: true).ToString();
        return await _searchClient.AdvancedPropertySearch(odata);
    }

    public async Task<List<ProjectSearchDto>> AdvancedProjectSearch()
    {
        var odata = new Odata(10, 0, "Id eq 66206", count: true).ToString();
        return await _searchClient.AdvancedProjectSearch(odata);
    }
    public async Task<ContactDto> GetContact(int id)
    {
        return await _contactClient.GetContactById(id);
    }

    public async Task<PersonDto> GetPerson(int id)
    {
        return await _contactClient.GetPersonById(id);
    }

    public async Task<EmployeeDto> GetEmployee(int id)
    {
        return await _contactClient.GetEmployeeById(id);
    }

    public async Task<IEnumerable<ContactDto>> GetContacts()
    {
        var odata = new Odata(10, 0, "Name eq 'Test'", "Name");
        return await _contactClient.GetContacts(odata.ToString());
    }

    public async Task<IEnumerable<OfficeDto>> GetOffices()
    {
        return await _contactClient.GetOffices();
    }

    public async Task<IEnumerable<ContactDto>> PaginationExample()
    {
        /*
         * Do a call to the API and read count.
         * Compare to received objects and calculate data retrieval by pages.
         */
        var odata = new Odata(count: true).ToString();
        var res = await _contactClient.GetContacts(odata);

        return res;
    }

    public async Task<string> GetSocialSecurityNumber(int id)
    {
        var person = await _contactClient.GetPersonById(id);
        var birthDate = person.BirthDate;
        var pnr = await _contactClient.GetFullIdentityNumber(id);

        Console.WriteLine($"{birthDate}{pnr}");

        return $"{birthDate}{pnr}";
    }

    public async Task<IEnumerable<EmployeeDto>> GetEmployeesOnOffice(int officeId, bool includeInactive = false)
    {
        return await _contactClient.GetEmployeesOnOffice(officeId, includeInactive);
    }

    public async Task<OfficeInformationDto?> GetOfficeInformation(int officeId)
    {
        return await _contactClient.GetOfficeInformation(officeId);
    }

    public async Task<IEnumerable<CaseJournalDto>> GetCaseJournals(int officeId)
    {
        var fromDate = DateTimeOffset.Now.AddDays(-30);
        var toDate = DateTimeOffset.Now;
        return await _contactClient.GetCaseJournals(officeId, fromDate, toDate);
    }

    public async Task<IEnumerable<DepotJournalDto>> GetRevenueJournalsSumGetDepotJournals(int officeId)
    {
        var fromDate = DateTimeOffset.Now.AddDays(-30);
        var toDate = DateTimeOffset.Now;
        return await _contactClient.GetDepotJournals(officeId, fromDate, toDate);
    }

    public async Task<IEnumerable<RevenueJournalDto>> GetRevenueJournals(int officeId)
    {
        var fromDate = DateTimeOffset.Now.AddDays(-30);
        var toDate = DateTimeOffset.Now;
        return await _contactClient.GetRevenueJournals(officeId, fromDate, toDate);
    }

    public async Task<RevenueJournalSumDto> GetRevenueJournalsSum(int officeId)
    {
        var fromDate = DateTimeOffset.Now.AddDays(-30);
        var toDate = DateTimeOffset.Now;
        return await _contactClient.GetRevenueJournalsSum(officeId, fromDate, toDate);
    }

    public async Task<IEnumerable<SettlementJournalDto>> GetSettlementJournals(int officeId)
    {
        var fromDate = DateTimeOffset.Now.AddDays(-30);
        var toDate = DateTimeOffset.Now;
        return await _contactClient.GetSettlementJournals(officeId, fromDate, toDate);
    }

    public async Task<IEnumerable<RecentlyModifiedCaseDto>> GetRecentlyModifiedCases()
    {
        var fromDate = DateTime.Now.AddDays(-1); // Maximum 365 days. You have to wait 30 seconds between each call or else you will be throttled.
        return await _generalClient.GetRecentlyModifiedCases(fromDate);
    }

    public async Task<IEnumerable<RecentlyModifiedContactDto>> GetRecentlyModifiedContacts()
    {
        var fromDate = DateTime.Now.AddDays(-1); // Maximum 365 days. You have to wait 30 seconds between each call or else you will be throttled.
        return await _generalClient.GetRecentlyModifiedContacts(fromDate);
    }

    public async Task<bool> GetCaseInfo(int caseId)
    {
        var residence = await _casesClient.GetResidence(caseId);
        var building = await _casesClient.GetBuilding(caseId);
        var propertyInformation = await _casesClient.GetPropertyInformation(caseId);
        var facilities = await _casesClient.GetFacilities(caseId);
        var landLotLeaseInformation = await _casesClient.GetLandLotLeaseInformation(caseId);
        var propertyConditions = await _casesClient.GetPropertyConditions(caseId);
        var publicTaxes = await _casesClient.GetPublicTaxes(caseId);
        var commonConditions = await _casesClient.GetCommonConditions(caseId);
        var caseAddress = await _casesClient.GetCaseAddress(caseId);

        Console.WriteLine($"Aksjenummer: {residence.BondNumber}");
        Console.WriteLine($"Beskrivelse av boligen: {building.Description}");
        Console.WriteLine($"Adresse: {caseAddress.Street}, {caseAddress.ZipCode} {caseAddress.City}");
        Console.WriteLine($"Eiendomsinformasjon: {propertyInformation.ShortPropertyDescription}");
        Console.WriteLine($"Garsje: {facilities.GarageParking}");
        Console.WriteLine($"Leie: {landLotLeaseInformation.LeaseFee}");
        Console.WriteLine($"Kommunale avgifter:{publicTaxes.LocalTaxes}");
        Console.WriteLine($"Prisantydning: {propertyConditions.AskingPrice}");
        Console.WriteLine($"Net kostnad: {commonConditions.NetCost}");

        return true;
    }

    public async Task<bool> UseDynamicSaleText(int caseId)
    {
        return await _adminClient.UseDynamicSaleText(caseId);
    }

    public async Task<IEnumerable<DynamicSaleTextMergedItemDto>> GetDynamicSaleTextItems(int caseId)
    {
        return await _adminClient.GetDynamicSaleTextItems(caseId);
    }

    public async Task<DynamicSaleTextMergedItemDto> GetDynamicSaleTextItem(int caseId, int itemId)
    {
        return await _adminClient.GetDynamicSaleTextItem(caseId, itemId);
    }

    public async Task<List<ExternalEntryDto>> GetExternalEntries(int caseId)
    {
        var externalEntries = await _adminClient.GetExternalEntries(caseId);

        // Print out the external entries
        foreach (var externalEntry in externalEntries)
        {
            Console.WriteLine($"External entry with id: {externalEntry.Id}");
            Console.WriteLine($"Amount: {externalEntry.Amount}");
            Console.WriteLine($"Comment: {externalEntry.Comment}");
            Console.WriteLine($"Credit number: {externalEntry.CreditNumber}");
            Console.WriteLine($"Debit number: {externalEntry.DebitNumber}");
            Console.WriteLine($"Entry date: {externalEntry.EntryDate}");
            Console.WriteLine($"Posting date: {externalEntry.PostingDate}");
            Console.WriteLine($"Case id: {externalEntry.CaseId}");
            Console.WriteLine($"Entry definition id: {externalEntry.EntryDefinitionId}");
            Console.WriteLine($"Entry id: {externalEntry.EntryId}");
            Console.WriteLine($"Entry id: {externalEntry.EntryDraftId}");
        }
        return externalEntries;
    }

    public async Task<ExternalEntryDto> CreateExternalEntry(int caseId)
    {
        // Get property from case id
        var properties = await _searchClient.AdvancedPropertySearch(new Odata(10, 0, $"Id eq 66115", "Id", count: true).ToString());
        var property = properties.FirstOrDefault();
        if (property == null || property.CaseCategoryType == CaseCategoryType.Unknown)
        {
            Console.WriteLine("No fitting CaseCategory found for this case.");
            throw new Exception($"No fitting CaseCategory found for this case. CaseId: {caseId}");
        }

        // If you want to create an entry or draft in the core accounting system, you *must* get a fitting entry definition.
        var entryDefinitions = await _economicsClient.GetEntryDefinitionsByCaseCategory(property.CaseCategoryType);

        if (!entryDefinitions.Any())
        {
            // At this point, you might want to throw an exception, but for the sake of the demo, we'll just continue.
        }

        // We'll just take the first entry definition for now
        var fittingEntryDefinition = entryDefinitions.FirstOrDefault();

        var externalEntry = new ExternalEntryRequest
        {
            Amount = 100,
            Comment = "Test",
            CreditNumber = 1000, // Does not have to correspond to core accounts
            DebitNumber = 2000,  // Does not have to correspond to core accounts
            EntryDate = DateTimeOffset.Now,
            PostingDate = DateTimeOffset.Now,
            CaseId = caseId,
            EntryDefinitionId = fittingEntryDefinition?.Id, // Only required if you want to create draft or entry
            CreateEntryDraft = fittingEntryDefinition != null // We want to create a draft
        };

        var createdExternalEntry = await _adminClient.CreateExternalEntry(externalEntry);
        Console.WriteLine($"Created external entry with id: {createdExternalEntry.Id}");

        return createdExternalEntry;
    }

    public async Task<IEnumerable<BankTransferTypeDto>> GetBankTransferTypes(int caseId, EntryDefinitionType entryDefinitionType, string? brokerCompanyOrgNum = null)
    {
        return await _integrationsClient.GetBankTransferTypes(caseId, entryDefinitionType, brokerCompanyOrgNum);
    }

    public async Task<BankTransferDto> CreateBankTransfer(int caseId)
    {
        var allowerBankTransferTypes = await GetBankTransferTypes(caseId, EntryDefinitionType.Boligkjøperforsikring);
        var bankTransferType = allowerBankTransferTypes.FirstOrDefault();
        if (bankTransferType == null)
        {
            throw new Exception("No bank transfer types found for this case.");
        }
        var request = new BankTransferRequest
        {
            BankTransferTypeId = bankTransferType.Id,
            Amount = 100,
            PaymentDate = DateTimeOffset.Now.AddDays(1),
            Comment = "Test From Demo-App",
            ReceiverIdentificationNumber = "541431470",
            ReceiverIsACompany = true,
            ReceiverName = "Core Demo App AS"

        };
        return await _integrationsClient.CreateBankTransfer(caseId, request);
    }

    public async Task<BankTransferDto> UpdateBankTransfer(int caseId, int bankTransferId)
    {
        var allowerBankTransferTypes = await GetBankTransferTypes(caseId, EntryDefinitionType.Boligkjøperforsikring);
        var bankTransferType = allowerBankTransferTypes.FirstOrDefault();
        if (bankTransferType == null)
        {
            throw new Exception("No bank transfer types found for this case.");
        }
        var request = new BankTransferRequest
        {
            Amount = 101,
            PaymentDate = DateTimeOffset.Now.AddDays(2),
            Comment = "Test From Demo-App - Update"
        };
        return await _integrationsClient.UpdateBankTransfer(caseId, bankTransferId, request);
    }

    public async Task<PublicPropertyInformationDto> GetPublicPropertyInformation(string caseGuid)
    {
        return await _publicClient.GetPublicPropertyInformation(caseGuid);
    }

    public async Task<List<ProcessingBasisDto>> GetActiveProcessingBasis()
    {
        return await _publicClient.GetActiveProcessingBases();
    }

    public async Task<List<ProcessingBasisDto>> GetProcessingBasesByType(ProcessingBasisCategoryType processingBasisCategoryType)
    {
        return await _publicClient.GetProcessingBasesByType(processingBasisCategoryType);
    }

    public async Task<List<ProcessingBasisDto>> GetProcessingBasesForProperty()
    {
        return await _publicClient.GetProcessingBasesForProperty();
    }

    public async Task<TypeResult<int>> CreateStakeholder(string caseGuid)
    {
        var activeProcessingBasis = await _publicClient.GetActiveProcessingBases();
        var anonymousCreateStakeholderRequest = new AnonymousCreateStakeholderRequest
        {
            FirstName = "Stakeholder",
            SurName = "Stakeholdersson",
            Email = "testmr1@webtop.no",
            // Telephone = "{StakeholderPhoneNumberHere}",
            CheckedProcessingBases = activeProcessingBasis.Select(x => x.Guid).ToList()
        };

        // Option two is to set ProcessingBasisCategory and ProcessingBasisSystemType in the create stakeholder request.
        // This option can only be used if you only need to add one processing basis for the created stakeholder:
        // var anonymousCreateStakeholderRequestOption2 = new AnonymousCreateStakeholderRequest
        // {
        //     FirstName = "Erik",
        //     SurName = "Molnar",
        //     Email = "erik.molnar@visma.com",
        //     Telephone = "+46730279460",
        //     CountryPrefix = "SE",
        //     ProcessingBasisCategory = ProcessingBasisCategoryType.SpecificCase,
        //     ProcessingBasisSystemType = ProcessingBasisSystemType.Manual
        // };
        return await _publicClient.CreateStakeholder(caseGuid, anonymousCreateStakeholderRequest);
    }

    // guid is the public property identificator of all cases.
    // You can find this via search or getting property information by Id.
    public async Task CreateOrderBrochure(string guid)
    {
        var activeProcessingBasis = await _publicClient.GetActiveProcessingBases();

        // Simulating that the user has consented to the processing bases for this case only.
        var consentedToThisCaseOnly =
            activeProcessingBasis.FirstOrDefault(x => x.CategoryType == ProcessingBasisCategoryType.SpecificCase);

        var request = new OrderBrochureRequest
        {
            FirstName = "Test",
            SurName = "Newman",
            Email = "{StakeholderEmailHere}",
            Telephone = "{StakeholderPhoneNumberHere}",
            Comments = "Test from CoreDemo",
            CheckedProcessingBases = new List<Guid> { consentedToThisCaseOnly?.Guid ?? Guid.Empty }
        };

        await _publicClient.OrderBrochure(guid, request);
    }

    public async Task<MarketingIntegratorOrderDto> CreateOrderOnBehalfOfCustomer(int caseId)
    {
        return await _adminClient.CreateOrderOnBehalfOfCustomer(caseId);
    }

    public async Task<MarketingIntegratorOrderDto> UpdateOrderState(Guid orderGuid)
    {
        return await _adminClient.UpdateOrderState(orderGuid);
    }

    public async Task<MarketingIntegratorOrderDto> UpdateOrderMetadata(Guid orderGuid)
    {
        return await _adminClient.UpdateOrderMetadata(orderGuid);
    }

    public async Task<MarketingIntegratorTokenDto> VerifyFlowToken(string flowToken)
    {
        return await _adminClient.VerifyFlowToken(flowToken);
    }

    public async Task<List<EntryDefinitionAdminDto>> GetExtendedEntryDefinitions()
    {
        bool includeDeleted = false;
        return await _economicsClient.GetExtendedEntryDefinitions(includeDeleted);
    }

    public async Task<object> CreateFolderAndUploadFile(int caseId)
    {
        var documentsFolderName = "MyNewDocumentsFolder3";
        var newFileName = "MyNewUploadedFile.txt";
        var filePath = $"{Environment.CurrentDirectory}/test.txt";

        try
        {
            var directory = await _casesClient.GetOrCreateNewFolder(caseId, documentsFolderName);
            var folderGuid = directory.Id;

            var fileTags = await _casesClient.GetFileTags();
            var fileTagsIds = fileTags
                //.Where(x => x.Name == "Dokumenter")
                //.Where(x => x.IsSystemTag == true)
                .Select(x => x.Id).ToList();

            var fileName = await _casesClient.UploadCaseFile(caseId, folderGuid, fileTagsIds, filePath, newFileName);

            Console.WriteLine("Successfully uploaded new file: " + fileName);

            return Task.FromResult(true);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Could not upload file. {ex.Message}");
            throw;
        }
    }

    public async Task<object> UploadImagesToCaseImageFolder(int caseId)
    {
        List<string> imagePaths = [
            $"{Environment.CurrentDirectory}/1.jpg",
            $"{Environment.CurrentDirectory}/2.jpg",
            $"{Environment.CurrentDirectory}/3.jpg"
        ];
        var export = true; // Whether to export the image, e.g. to Finn.no.

        try
        {
            var fileNames = await _casesClient.UploadImagesToCase(caseId, imagePaths, export);

            return Task.FromResult(fileNames);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Could not upload image. {ex.Message}");
            throw;
        }
    }

    public async Task<List<int>> GetKeyInfoFromPublishedCases()
    {
        try
        {
            var type = PublicationProviderType.Finn;
            var publishedCaseIds = await _casesClient.GetActivePublications(type);

            foreach (var caseId in publishedCaseIds.Take(1))
            {
                // Await each call to prevent being throttled. Adjust according to your requirements.
                var caseAddress = await _casesClient.GetCaseAddress(caseId);
                var caseResidence = await _casesClient.GetResidence(caseId);
                var caseCommonConditions = await _casesClient.GetCommonConditions(caseId);

                Console.WriteLine($"Address: {caseAddress.Street}, {caseAddress.ZipCode} {caseAddress.City}");
                Console.WriteLine($"Bond number (Aksjenummer): {caseResidence.BondNumber}");
                Console.WriteLine($"Net cost: {caseCommonConditions.NetCost}");
            }

            return publishedCaseIds;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Could not get key info from published cases. {ex.Message}");
            throw;
        }
    }

    public async Task<object> GetCompleteDynamicSalesTextFromCase(int caseId)
    {
        try
        {
            var caseUsesDynamicSalesText = await _adminClient.UseDynamicSaleText(caseId);
            if (caseUsesDynamicSalesText)
            {
                var dynamicSalesTextItems = await _adminClient.GetDynamicSaleTextItems(caseId);

                foreach (var item in dynamicSalesTextItems)
                {
                    Console.WriteLine("Id: " + item.Id);
                    Console.WriteLine("Header level: " + item.Level);
                    Console.WriteLine("Header: " + item.Header);
                    Console.WriteLine("Text: " + item.Text);
                }

                return dynamicSalesTextItems;
            }

            return Enumerable.Empty<DynamicSaleTextMergedItemDto>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Could not get dynamic sales text items from case. {ex.Message}");
            throw;
        }
    }

    public async Task<List<DocumentSigningDto>> GetDocumentSignaturesOfPersonsOnCase(int caseId)
    {
        try
        {
            var caseDocSignatures = await _casesClient.GetCaseDocumentSignatures(caseId);

            foreach (var item in caseDocSignatures)
            {
                // Get information of each person signing the document
                foreach (var task in item.Tasks)
                {
                    var personId = task.ContactId;
                    var person = await _contactClient.GetPersonById(personId);
                    Console.WriteLine(person.FirstName); // The person signing

                    foreach (var onBehalfOf in task.SigningOnBehalfOf ?? new List<int>())
                    {
                        var onBehalfOfPerson = await _contactClient.GetPersonById(onBehalfOf);
                        Console.WriteLine(onBehalfOfPerson.FirstName); // Signing on behalf of this person
                    }
                }
            }

            return caseDocSignatures;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Could not get document signatures. {ex.Message}");
            throw;
        }
    }

    public async Task<List<DirectoryItemDto>> GetCaseFilesDirectory(int caseId)
    {
        return await _casesClient.GetCaseFilesDirectory(caseId);
    }

    public async Task<object> GetCaseFile(int caseId, string fileGuid)
    {
        return await _casesClient.GetCaseFile(caseId, fileGuid);
    }

    public async Task<object> GetCaseImage(int caseId, string fileGuid, string imageSize)
    {
        var image = await _casesClient.GetCaseImage(caseId, fileGuid, imageSize);
        Console.WriteLine($"StatusCode for GetCaseImage: { image.StatusCode}");

        // You should store the Etag together with the image.
        // All files/images returns a checksum you can later include in the request to skip already downloaded files, unless they have been updated.
        // Ref. https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/ETag
        var etag = image.Headers.ETag;

        var downloadTheSameImage = await _casesClient.GetCaseImage(caseId, fileGuid, imageSize, etag); // Should return 304 Not-Modified.
        Console.WriteLine($"StatusCode for GetCaseImage, download second time: {downloadTheSameImage.StatusCode}");

        return new object();
    }

    public async Task<object> GetFileTags()
    {
        return await _casesClient.GetFileTags();
    }

    public async Task<IEnumerable<ActivityModelDto>> GetActivities()
    {
        var odata = new Odata(100, 0, "ActivityType eq 'ShowingActivity'", "LastModified", true);
        return await _activitiesClient.GetActivities(odata.ToString());
    }

    public async Task<IEnumerable<ActivityParticipantModelDto>> GetParticipantsForActivity(int activityId)
    {
        return await _activitiesClient.GetParticipantsForActivity(activityId);
    }

    public async Task<IEnumerable<ContactDto>> GetContactsForActivity(int activityId)
    {
        return await _activitiesClient.GetContactsForActivity(activityId);
    }

    public async Task<IEnumerable<ActivityModelDto>> GetActivitiesForContact(int contactId)
    {
        var fromDate = new DateTime(2024, 1, 9, 23, 0, 0);
        var toDate = new DateTime(2024, 6, 27, 23, 0, 0);

        return await _activitiesClient.GetActivitiesForContact(contactId, fromDate, toDate);
    }

    public async Task<IEnumerable<CommissionSharingDto>> GetCommissionSharingForCase(int caseId, CommissionSharingType type)
    {
        var commissionSharingOnCase = await _salaryClient.GetCommissionSharingForCase(caseId, type);
        foreach (var commissionSharing in commissionSharingOnCase)
        {
            var employee = await _contactClient.GetEmployeeById(commissionSharing.EmployeeId);
            Console.WriteLine($"Employee: {employee.FirstName} {employee.SurName}: {commissionSharing.Percentage}%");
        }

        return commissionSharingOnCase;
    }

    public async Task<int> GetEntityBaseActiveBrokerCompanyId(int entityBaseId)
    {
        return await _usersClient.GetActiveBrokerCompanyId(entityBaseId);
    }
}
