using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Search;

public class PropertySearchDto : CaseSearchDto
{
    /// <summary>
    /// The RevenueJournal number.
    /// </summary>
    public string? RevenueReferralKey { get; set; }

    /// <summary>
    /// The revenue payment
    /// </summary>
    public decimal? RevenuePayment { get; set; }

    /// <summary>
    /// The date when this property is sold
    /// </summary>
    public DateTime? SoldDate { get; set; }

    /// <summary>
    /// The minimum number of bedrooms for the given property.
    /// </summary>
    public int? NumberOfBedrooms { get; set; }

    /// <summary>
    /// The minimum number of rooms for the given property.
    /// </summary>
    public int? NumberOfRooms { get; set; }

    /// <summary>
    /// The minimum number of bathrooms for the given property.
    /// </summary>
    public int? NumberOfBathrooms { get; set; }

    /// <summary>
    /// The living size of the given property
    /// </summary>
    public decimal? LivingArea { get; set; }

    /// <summary>
    /// Number of Parking Lots
    /// </summary>
    public int? NumberOfParkingLots { get; set; }

    /// <summary>
    /// The gross area size of the given property
    /// </summary>
    public decimal? GrossArea { get; set; }

    /// <summary>
    /// BRA-i (Internt bruksareal)
    /// </summary>
    public decimal? GrossInternalArea { get; set; }

    /// <summary>
    /// BRA-i to (Internt bruksareal)
    /// </summary>
    public decimal? GrossInternalAreaTo { get; set; }

    /// <summary>
    /// BRA-e (Eksternt bruksareal)
    /// </summary>
    public decimal? GrossExternalArea { get; set; }

    /// <summary>
    /// BRA-e to (Eksternt bruksareal)
    /// </summary>
    public decimal? GrossExternalAreaTo { get; set; }

    /// <summary>
    /// BRA-b (Innglasset balkong)
    /// </summary>
    public decimal? EnclosedBalconyArea { get; set; }

    /// <summary>
    /// BRA-b to (Innglasset balkong)
    /// </summary>
    public decimal? EnclosedBalconyAreaTo { get; set; }

    /// <summary>
    /// Åpent areal
    /// </summary>
    public decimal? OpenArea { get; set; }

    /// <summary>
    /// Åpent areal til
    /// </summary>
    public decimal? OpenAreaTo { get; set; }

    /// <summary>
    /// Total floor area
    /// </summary>
    public decimal? TotalFloorArea {  get; set; }

    /// <summary>
    /// Low ceiling area
    /// </summary>
    public decimal? LowCeilingArea { get; set; }

    /// <summary>
    /// The floorspace
    /// </summary>
    public decimal? FloorSpace { get; set; }

    /// <summary>
    /// The storey of this building
    /// </summary>
    public int? Storey { get; set; }

    /// <summary>
    /// Does the property have a basement
    /// </summary>
    public bool? IsBasement { get; set; }

    /// <summary>
    /// The year the given property was built
    /// </summary>
    public int? BuiltYear { get; set; }

    /// <summary>
    /// The asking price for the property.
    /// </summary>
    public decimal? AskingPrice { get; set; }

    /// <summary>
    /// The sale price for the property.
    /// </summary>
    public decimal? SalePrice { get; set; }

    /// <summary>
    /// The the ratio between sale price and asking price for the property.
    /// </summary>
    public double? AskingAndSalePriceDifference { get; set; }

    /// <summary>
    /// The price per square meters for the property.
    /// Price/floorSpace. This is estiamted from asking price or sold price.
    /// </summary>
    public decimal? PricePerFloorSpace { get; set; }

    /// <summary>
    /// The price per square meters for the property.
    /// Price/PrimaryRoomSpace. This is estiamted from asking price or sold price.
    /// </summary>
    public decimal? PricePerPrimaryRoomSpace { get; set; }

    /// <summary>
    /// The date the bid was accepted for the property.
    /// </summary>
    public DateTime? BidAcceptedDate { get; set; }

    /// <summary>
    /// The current active bid was created
    /// </summary>
    public DateTime? ActiveBidDate { get; set; }

    /// <summary>
    /// The amount on the current active bid
    /// </summary>
    public decimal? ActiveBidAmount { get; set; }

    /// <summary>
    /// When the date was due for the active bid
    /// </summary>
    public DateTime? ActiveBidDueDate { get; set; }

    /// <summary>
    /// A list of buyers
    /// </summary>
    public IEnumerable<string> Buyers { get; set; } = new List<string>();

    /// <summary>
    /// Email of the buyers
    /// </summary>
    public IEnumerable<string> BuyerEmails { get; set; } = new List<string>();

    /// <summary>
    /// Phone of the buyers
    /// </summary>
    public IEnumerable<string> BuyerPhones { get; set; } = new List<string>();

    /// <summary>
    /// A list of zip codes
    /// </summary>
    public IEnumerable<string> BuyerZipCodes { get; set; } = new List<string>();

    /// <summary>
    /// The current status of the settlement
    /// </summary>
    public SettlementStatusType SettlementStatus { get; set; }

    /// <summary>
    /// The name of the current status of the settlement
    /// </summary>
    public string? SettlementStatusString { get; set; }

    /// <summary>
    /// Id to the Project, only exists if the case is a Project Unit
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// Name of the project build step, will fall back on main project if projectStep is NULL
    /// </summary>
    public string? ProjectStepName { get; set; }

    /// <summary>
    /// Status of the project build step, will fall back on main project if projectStep is NULL
    /// </summary>
    public string? ProjectStepStatus { get; set; }

    /// <summary>
    /// Name of the project master if this is a project unit
    /// </summary>
    public string? ProjectMasterName { get; set; }

    /// <summary>
    /// Id to the Project master, only exists if the case is a Project Unit
    /// </summary>
    public int? ProjectMasterId { get; set; }

    /// <summary>
    /// Shared debt in a housingAssociation
    /// </summary>
    public double? CommonDebt { get; set; }

    /// <summary>
    /// All ids of stakeholders for the property.
    /// </summary>
    public int[] BidderIds { get; set; } = [];

    /// <summary>
    /// Date of verdict from foreclosure information.
    /// </summary>
    public DateTime? VerdictDate { get; set; }

    /// <summary>
    /// Dissemination date from foreclosure information.
    /// </summary>
    public DateTime? DisseminationDate { get; set; }

    /// <summary>
    /// Court case date from foreclosure information.
    /// </summary>
    public DateTime? CourtCaseDate { get; set; }

    /// <summary>
    /// Date when reservation was created
    /// </summary>
    public DateTime? ReservationCreatedDate { get; set; }

    /// <summary>
    /// Date when reservation expires
    /// </summary>
    public DateTime? ReservationExpirationDate { get; set; }

    /// <summary>
    /// Does seller want seller insurance
    /// </summary>
    public SellerInsuranceType SellerInsuranceType { get; set; }

    /// <summary>
    /// Custom data field; usage and content will vary between customers.
    /// </summary>
    public string? CustomData { get; set; }

    /// <summary>
    /// Type of sale transaction (Omsetningstype)
    /// https://www.ssb.no/klass/klassifikasjoner/21
    /// </summary>
    public SaleTransactionType? SaleTransactionType { get; set; }

    /// <summary>
    /// Date when it was archived
    /// </summary>
    public DateTime? DocumentDeliveryDate { get; set; }

    /// <summary>
    /// Date when it was last archived
    /// </summary>
    public DateTime? LastDocumentDeliveryDate { get; set; }
}
