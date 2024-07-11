using CoreDemo.Models.Enums;
namespace CoreDemo.Models.Contacts;

/// <summary>
/// Revenuel Journal model
/// </summary>
public class RevenueJournalDto
{
    /// <summary>
    /// annotations list
    /// </summary>
    public IEnumerable<RevenueJournalAnnotationDto>? Annotations { get; set; }

    /// <summary>
    /// contract date
    /// </summary>
    public DateTimeOffset? ContractDate { get; set; }

    /// <summary>
    /// settlement date
    /// </summary>
    public DateTimeOffset? SettlementDate { get; set; }

    /// <summary>
    /// purchase price / annual hire charge
    /// </summary>
    public decimal PurchasePrice { get; set; }

    /// <summary>
    /// revenue date
    /// </summary>
    public DateTimeOffset RevenueDate { get; set; }

    /// <summary>
    /// payment
    /// </summary>
    public decimal? Payment { get; set; }

    /// <summary>
    /// Revenue referral key
    /// </summary>
    public string? RevenueReferralKey { get; set; }

    /// <summary>
    /// ownership type
    /// </summary>
    public string? OwnershipType { get; set; }

    /// <summary>
    /// property address
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// seller name / info
    /// </summary>
    public string? SellerInfo { get; set; }

    /// <summary>
    /// buyer infor / name
    /// </summary>
    public string? BuyerInfo { get; set; }

    /// <summary>
    /// registry description
    /// </summary>
    public string? RegistryDescription { get; set; }

    /// <summary>
    /// Case referral key
    /// </summary>
    public string? CaseReferralKey { get; set; }

    /// <summary>
    /// Responsible broker name (Firstname and surname).
    /// </summary>
    public string? ResponsibleBrokerName { get; set; }

    /// <summary>
    /// Eiendomsmeglerfullmektig
    /// </summary>
    public string? RealEstateRepresentativeName { get; set; }

    /// <summary>
    /// Assignment type of the case
    /// </summary>
    public AssignmentType Type { get; set; }

    /// <summary>
    /// Office
    /// </summary>
    public string? OfficeName { get; set; }

    /// <summary>
    /// Broker company name
    /// </summary>
    public string? BrokerCompanyName { get; set; }
}
