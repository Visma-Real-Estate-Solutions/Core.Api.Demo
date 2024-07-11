using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Search;

// Basemodel for search
// Inherited by Property and Project search models
public class CaseSearchDto
{
    /// <summary>
    /// The case id.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// The case id not generated to URL.
    /// </summary>
    /// <remarks>
    /// The Id field is converted into case URL during export in advanced search
    /// Added this field to be able to retrieve just the Id
    /// </remarks>
    public int? CaseId { get; set; }

    /// <summary>
    /// The Id when this case is imported
    /// </summary>
    public string? ExternalId { get; set; }

    /// <summary>
    /// The chain identificator.
    /// </summary>
    public int? ChainId { get; set; }

    /// <summary>
    /// Broker Company Id
    /// </summary>
    public int? BrokerCompanyId { get; set; }

    /// <summary>
    /// Id of the office
    /// </summary>
    public int? OfficeId { get; set; }

    /// <summary>
    /// The office name.
    /// </summary>
    public string? Office { get; set; }

    /// <summary>
    /// Settlement company on the property
    /// </summary>
    public int? SettlementCompanyId { get; set; }

    /// <summary>
    /// Name of the settlement company on the property
    /// </summary>
    public string? SettlementCompanyName { get; set; }

    /// <summary>
    /// Broker company id for the settlement company if it is an office
    /// </summary>
    public int? SettlementOfficeBrokerCompanyId { get; set; }

    /// <summary>
    /// If the settlement company is an office
    /// </summary>
    public int? SettlementOfficeId { get; set; }

    /// <summary>
    /// The case status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The external case status name.
    /// </summary>
    public string? ExternalStatus { get; set; }

    /// <summary>
    /// The case status type.
    /// </summary>
    public CaseStatusType CaseStatusType { get; set; }

    /// <summary>
    /// Date when this case was created
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The case number
    /// </summary>
    public string? CaseReferralKey { get; set; }

    /// <summary>
    /// The type of this case
    /// </summary>
    public CaseCategoryType CaseCategoryType { get; set; }

    /// <summary>
    /// The type of this assignment
    /// </summary>
    public AssignmentType AssignmentType { get; set; }

    /// <summary>
    /// The residence unit type.
    /// </summary>
    public UnitType UnitType { get; set; }

    /// <summary>
    /// The residence ownership type.
    /// </summary>
    public OwnershipType OwnershipType { get; set; }

    /// <summary>
    /// Id of the responsible broker
    /// </summary>
    public int? ResponsibleBrokerId { get; set; }

    /// <summary>
    /// Name of the responsible broker
    /// </summary>
    public string? ResponsibleBrokerName { get; set; }

    /// <summary>
    /// Id of the broker
    /// </summary>
    public int? BrokerId { get; set; }

    /// <summary>
    /// Name of the broker
    /// </summary>
    public string? BrokerName { get; set; }

    /// <summary>
    /// The initials for the broker
    /// </summary>
    public string? BrokerInitials { get; set; }

    /// <summary>
    /// Id of the assistant broker
    /// </summary>
    public int? AssistantBrokerId { get; set; }

    /// <summary>
    /// Name of the assistant broker
    /// </summary>
    public string? AssistantBrokerName { get; set; }

    /// <summary>
    /// Id of the associate broker
    /// </summary>
    public int? AssociateBrokerId { get; set; }

    /// <summary>
    /// Name of the assistant broker
    /// </summary>
    public string? AssociateBrokerName { get; set; }

    /// <summary>
    /// Id of the assistant
    /// </summary>
    public int? AssistantId { get; set; }

    /// <summary>
    /// Name of the assistant
    /// </summary>
    public string? AssistantName { get; set; }

    /// <summary>
    /// Id of the Appraiser
    /// </summary>
    public int? AppraiserId { get; set; }

    /// <summary>
    /// Name of the Appraiser
    /// </summary>
    public string? AppraiserName { get; set; }

    /// <summary>
    /// Id of the JointOwner
    /// </summary>
    public int? JointOwnerId { get; set; }

    /// <summary>
    /// Name of the JointOwner
    /// </summary>
    public string? JointOwnerName { get; set; }

    /// <summary>
    /// Id of the BusinessManager
    /// </summary>
    public int? BusinessManagerId { get; set; }

    /// <summary>
    /// Name of the BusinessManager
    /// </summary>
    public string? BusinessManagerName { get; set; }

    /// <summary>
    /// Id of the HousingAssociation
    /// </summary>
    public int? HousingAssociationId { get; set; }

    /// <summary>
    /// Name of the housing association
    /// </summary>
    public string? HousingAssociationName { get; set; }

    /// <summary>
    /// The organisation number of the housing association
    /// </summary>
    public string? HousingAssociationOrganisationNumber { get; set; }

    /// <summary>
    /// The Id of the person whos settlement responsible
    /// </summary>
    public int? SettlementResponsibleId { get; set; }

    /// <summary>
    /// The name of the person whos settlement responsible
    /// </summary>
    public string? SettlementResponsibleName { get; set; }

    /// <summary>
    /// A list of seller ids
    /// </summary>
    public IEnumerable<int>? SellerIds { get; set; }

    /// <summary>
    /// A list of seller names
    /// </summary>
    public IEnumerable<string>? Sellers { get; set; }

    /// <summary>
    /// Email of the sellers
    /// </summary>
    public IEnumerable<string>? SellerEmails { get; set; }

    /// <summary>
    /// Phone of the sellers
    /// </summary>
    public IEnumerable<string>? SellerPhones { get; set; }

    /// <summary>
    /// The full address for the given property.
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// The city.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// The municipality
    /// </summary>
    public string? Municipality { get; set; }

    /// <summary>
    /// The municipality
    /// </summary>
    public string? MunicipalityNumber { get; set; }

    /// <summary>
    /// The country
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// The County
    /// </summary>
    public string? County { get; set; }

    /// <summary>
    /// The name of the area for the given property.
    /// </summary>
    public string? Area { get; set; }

    /// <summary>
    /// The name of the area that is displayed in marketing material.
    /// </summary>
    public string? AreaInMarketing { get; set; }

    /// <summary>
    /// The zip-code.
    /// </summary>
    public string? ZipCode { get; set; }

    /// <summary>
    /// The street address.
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// Kommunenummer fra matrikkelen.
    /// </summary>
    public string? Knr { get; set; }

    /// <summary>
    /// Gårdsnummer
    /// </summary>
    public int? Gnr { get; set; }

    /// <summary>
    /// Bruksnummer
    /// </summary>
    public int? Bnr { get; set; }

    /// <summary>
    /// Seksjonsnummer
    /// </summary>
    public int? Snr { get; set; }

    /// <summary>
    /// Festenummer
    /// </summary>
    public int? Fnr { get; set; }

    /// <summary>
    /// Andelsnummer
    /// </summary>
    public int? CooperativeNumber { get; set; }

    /// <summary>
    /// AppartmentNumber is used as a string
    /// </summary>
    public string? ApartmentNumber { get; set; }

    /// <summary>
    /// The land lot size of the given property
    /// </summary>
    public decimal? LandLotSize { get; set; }

    /// <summary>
    /// The date when this case was last opened
    /// </summary>
    public DateTime? LastOpenedDate { get; set; }

    /// <summary>
    /// The date when this case was last published
    /// </summary>
    public DateTime? LastPublishedDate { get; set; }

    /// <summary>
    /// The date when status for this case was changed
    /// </summary>
    public DateTime? LastStatusChangeDate { get; set; }

    /// <summary>
    /// Home publishing date
    /// </summary>
    /// If we gonna ever use this query is like this Publications.Where(x => x.CaseBaseId == sale.Id && x.PublicationProvider.Home).Max(x => x.UpdatedDate)
    [Obsolete("no one is using this")]
    public DateTime? LastHomePublishDate { get; set; }

    /// <summary>
    /// Lauch day
    /// </summary>
    public DateTime? LaunchDay { get; set; }

    /// <summary>
    /// Additional infomation about this case assignment
    /// </summary>
    public IEnumerable<AssignmentInfoType>? AssignmentInfoTypes { get; set; }

    /// <summary>
    /// Phase type on a case
    /// </summary>
    public CasePhaseType CasePhaseType { get; set; }

    /// <summary>
    /// Sellers currency balance for a caseBase
    /// </summary>
    public decimal? SellerSum { get; set; }

    /// <summary>
    /// A list of buyer ids
    /// </summary>
    public IEnumerable<int>? BuyerIds { get; set; }

    /// <summary>
    /// Buyers currency balance for a caseBase (buyer is only on property atm)
    /// </summary>
    public decimal? BuyerSum { get; set; }

    /// <summary>
    /// Brokers currency balance for a caseBase
    /// </summary>
    public decimal? BrokerSum { get; set; }

    /// <summary>
    /// Banks currency balance for a caseBase
    /// </summary>
    public decimal? BankSum { get; set; }

    /// <summary>
    /// Sum of sale commission
    /// </summary>
    public decimal? CommissionSum { get; set; }

    /// <summary>
    /// The date the contact starts for the case.
    /// </summary>
    public DateTime? ContractStartDate { get; set; }

    /// <summary>
    /// The date the contact ends for the case.
    /// </summary>
    public DateTime? ContractEndDate { get; set; }

    /// <summary>
    /// The economy notes on settlements
    /// </summary>
    public IEnumerable<string>? EconomyNotes { get; set; }

    /// <summary>
    /// The flag IsReady is set in string format
    /// </summary>
    public string? IsReady { get; set; }

    /// <summary>
    /// The flag IsMarketable is set in string format
    /// </summary>
    public string? IsMarketable { get; set; }

    /// <summary>
    /// The flag IsSold is set in string format
    /// </summary>
    public string? IsSold { get; set; }

    /// <summary>
    /// The date transfer was gonna happen for the property.
    /// </summary>
    public DateTime? TransferDate { get; set; }

    /// <summary>
    /// The location transfer was gonna happen for the property.
    /// </summary>
    public string? TransferLocation { get; set; }

    /// <summary>
    /// The date of the inspection for the property.
    /// </summary>
    public DateTime? InspectionDate { get; set; }

    /// <summary>
    /// The date of the showing for the property.
    /// </summary>
    public DateTime? ShowingDate { get; set; }

    /// <summary>
    /// All dates of showings for the property.
    /// </summary>
    public DateTime?[] ShowingDates { get; set; } = [];

    /// <summary>
    /// All ids of showings for the property. Matches with showingDates by index
    /// </summary>
    public int[] ShowingIds { get; set; } = [];

    /// <summary>
    /// All ids of stakeholders for the property.
    /// </summary>
    public int[] StakeholderIds { get; set; } = [];

    /// <summary>
    /// All ids of stakeholders for the property that is !NotInterested.
    /// </summary>
    public int[] InterestedStakeholderIds { get; set; } = [];

    /// <summary>
    /// The contract meeting date for a sale
    /// </summary>
    public DateTime? ContractMeetingDate { get; set; }

    /// <summary>
    /// The contract signing date for a sale
    /// </summary>
    public DateTime? ContractSigningDate { get; set; }

    /// <summary>
    /// The next seller stipulation deadline
    /// </summary>
    public DateTime? NextStipulationDeadline { get; set; }

    /// <summary>
    /// Comments for seller stipulations
    /// </summary>
    public IEnumerable<string>? StipulationComments { get; set; }

    /// <summary>
    /// List of plaintiffs.
    /// </summary>
    public IEnumerable<string>? Plaintiffs { get; set; }

    /// <summary>
    /// District court case numbers, from plaintiffs.
    /// </summary>
    public IEnumerable<string>? DistrictCourtCaseNumbers { get; set; }

    /// <summary>
    /// The energy label.
    /// </summary>
    public EnergyLabel EnergyLabel { get; set; }

    /// <summary>
    /// The heating grade (EnergyColorCode)
    /// </summary>
    public HeatingGrade HeatingGrade { get; set; }

    /// <summary>
    /// Date when the case was sent to settlement team
    /// </summary>
    public DateTime? SentToSettlementTeam { get; set; }

    /// <summary>
    /// Date when settlement team received the case
    /// </summary>
    public DateTime? ReceivedBySettlementTeam { get; set; }

    /// <summary>
    /// Date when the case was activated
    /// </summary>
    public DateTime? CaseActivatedDate { get; set; }

    /// <summary>
    /// Date when the case was last activated
    /// </summary>
    public DateTime? LastCaseActivatedDate { get; set; }

    // <summary>
    /// Date when the case was set ready
    /// </summary>
    public DateTime? CaseReadyDate { get; set; }

    /// <summary>
    /// Date when the case was set ready
    /// </summary>
    public DateTime? LastCaseReadyDate { get; set; }

    /// <summary>
    /// Date when it was set to sold
    /// </summary>
    public DateTime? CaseSoldDate { get; set; }

    /// <summary>
    /// Date when it was archived
    /// </summary>
    public DateTime? CaseArchivedDate { get; set; }

    /// <summary>
    /// Date when it was last archived
    /// </summary>
    public DateTime? LastCaseArchivedDate { get; set; }

    /// <summary>
    /// Date when it was set to general
    /// </summary>
    public DateTime? CaseStatusGeneralDate { get; set; }

    /// <summary>
    /// Date when it was last set to general
    /// </summary>
    public DateTime? LastCaseStatusGeneralDate { get; set; }

    /// <summary>
    /// Date when it was set to initial
    /// </summary>
    public DateTime? CaseStatusInitialDate { get; set; }

    /// <summary>
    /// Date when it was last set to initial
    /// </summary>
    public DateTime? LastCaseStatusInitialDate { get; set; }

    /// <summary>
    /// Date when it was set to draft
    /// </summary>
    public DateTime? CaseStatusDraftDate { get; set; }

    /// <summary>
    /// Date when it was last set to draft
    /// </summary>
    public DateTime? LastCaseStatusDraftDate { get; set; }

    /// <summary>
    /// Date when it was set to reserved
    /// </summary>
    public DateTime? CaseStatusReservedDate { get; set; }

    /// <summary>
    /// Date when it was last set to reserved
    /// </summary>
    public DateTime? LastCaseStatusReservedDate { get; set; }

    /// <summary>
    /// Date when it was set to bidding started
    /// </summary>
    public DateTime? CaseStatusBiddingStartedDate { get; set; }

    /// <summary>
    /// Date when it was last set to bidding started
    /// </summary>
    public DateTime? LastCaseStatusBiddingStartedDate { get; set; }

    /// <summary>
    /// Date when it was set to cancelled
    /// </summary>
    public DateTime? CaseStatusCanceledDate { get; set; }

    /// <summary>
    /// Date when it was last set to cancelled
    /// </summary>
    public DateTime? LastCaseStatusCanceledDate { get; set; }

    /// <summary>
    /// Date when it was set to followup
    /// </summary>
    public DateTime? CaseStatusFollowupDate { get; set; }

    /// <summary>
    /// Date when it was last set to followup
    /// </summary>
    public DateTime? LastCaseStatusFollowupDate { get; set; }

    /// <summary>
    /// Date when it was set to lost
    /// </summary>
    public DateTime? CaseStatusLostDate { get; set; }

    /// <summary>
    /// Date when it was last set to lost
    /// </summary>
    public DateTime? LastCaseStatusLostDate { get; set; }

    /// <summary>
    /// Date when it was settlement waiting
    /// </summary>
    public DateTime? SettlementWaitingDate { get; set; }

    /// <summary>
    /// Date when it was last settlement waiting
    /// </summary>
    public DateTime? LastSettlementWaitingDate { get; set; }

    /// <summary>
    /// Date when it was settlement general
    /// </summary>
    public DateTime? SettlementGeneralDate { get; set; }

    /// <summary>
    /// Date when it was last settlement general
    /// </summary>
    public DateTime? LastSettlementGeneralDate { get; set; }

    /// <summary>
    /// Date when it was transferred to settlement
    /// </summary>
    public DateTime? TransferredToSettlementDate { get; set; }

    /// <summary>
    /// Date when it was last transferred to settlement
    /// </summary>
    public DateTime? LastTransferredToSettlementDate { get; set; }

    /// <summary>
    /// Date when it was settlement received
    /// </summary>
    public DateTime? SettlementReceivedDate { get; set; }

    /// <summary>
    /// Date when it was last settlement received
    /// </summary>
    public DateTime? LastSettlementReceivedDate { get; set; }

    /// <summary>
    /// Date when it was deed sent to registration
    /// </summary>
    public DateTime? DeedSentToRegistrationDate { get; set; }

    /// <summary>
    /// Date when it was last deed sent to registration
    /// </summary>
    public DateTime? LastDeedSentToRegistrationDate { get; set; }

    /// <summary>
    /// Date when it was archived
    /// </summary>
    public DateTime? SettlementReadyDate { get; set; }

    /// <summary>
    /// Date when it was last archived
    /// </summary>
    public DateTime? LastSettlementReadyDate { get; set; }

    /// <summary>
    /// Date when it was archived
    /// </summary>
    public DateTime? SettlementDoneDate { get; set; }

    /// <summary>
    /// Date when it was last archived
    /// </summary>
    public DateTime? LastSettlementDoneDate { get; set; }

    /// <summary>
    /// Date when it was archived
    /// </summary>
    public DateTime? SettlementArchivedDate { get; set; }

    /// <summary>
    /// Date when it was last archived
    /// </summary>
    public DateTime? LastSettlementArchivedDate { get; set; }

    /// <summary>
    /// Last time a bid was added to this case
    /// </summary>
    public DateTime? BidChangedDate { get; set; }

    /// <summary>
    /// Date when description of the case was changed,
    /// this includes fields such as CommonCondition, Building, SaleInformation,
    /// </summary>
    public DateTime? DescriptionChangedDate { get; set; }

    /// <summary>
    /// Date when a new contact is added to this case
    /// </summary>
    public DateTime? CaseEntityChangedDate { get; set; }

    /// <summary>
    /// Last time an image file is added or deleted
    /// </summary>
    public DateTime? ImageChangedDate { get; set; }

    /// <summary>
    /// Date attachment file is changed,
    /// attachment file being the files inside attachment system folder
    /// </summary>
    public DateTime? AttachmentChangedDate { get; set; }

    /// <summary>
    /// Date when transaction is changed
    /// </summary>
    public DateTime? TransactionChangedDate { get; set; }

    /// <summary>
    /// Date publication was changed last time
    /// </summary>
    public DateTime? PublicationChangedDate { get; set; }

    /// <summary>
    /// Date when activity was changed last time
    /// </summary>
    public DateTime? ActivityChangedDate { get; set; }

    /// <summary>
    /// Etinglysing case status type
    /// </summary>
    public EtinglysingCaseStatusType EtinglysingCaseStatusType { get; set; }

    /// <summary>
    /// Case is using factoring or not
    /// </summary>
    public UseFactoringCategory UseFactoringCategory { get; set; }
}
