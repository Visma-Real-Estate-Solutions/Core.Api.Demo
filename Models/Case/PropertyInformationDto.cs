using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Case;

public class PropertyInformationDto
{
    public int Id { get; set; }
    public string? Details { get; set; }
    public string? Contents { get; set; }
    public string? LocationDescription { get; set; }
    public LocationType? LocationType { get; set; }
    public string? ShortPropertyDescription { get; set; }
    public string? ValuationDescription { get; set; }
    public int? NumberOfParkingLots { get; set; }
    public string? Radon { get; set; }
    public string? LawRequiredDemands { get; set; }
    public string? CentralLaws { get; set; }
    public string? BuyerInsurance { get; set; }
    public string? Prepayment { get; set; }
    public string? Attachments { get; set; }
    public string? Disclaimer { get; set; }
    public string? DeclarationOfConcessionFreedom { get; set; }
    public string? OtherAgreements { get; set; }
    public string? ImportantInformationComment { get; set; }
    public string? PreemptionComment { get; set; }
    public string? Progression { get; set; }
    public string? Completion { get; set; }
    public string? Appliances { get; set; }
    public string? MarketingHeader { get; set; }
    public bool AsIs { get; set; }
    public string? ShortDeliveryDescription { get; set; }
    public DateTime? CompletionDate { get; set; }
    public DateTime? TemporaryPermitRegisteredDate { get; set; }
    public DateTime? TemporaryPermitExpiryDate { get; set; }
    public string? ValuationComment { get; set; }
    public string? BidProcessComment { get; set; }
    public string? ShowingComment { get; set; }
    public string? UsefulTips { get; set; }
    public string? FinanceComment { get; set; }
    public string? OtherRightsAndObligations { get; set; }
    public SellerInsuranceType? SellerInsuranceType { get; set; }
    public ConstructionPhaseType? CurrentConstructionPhase { get; set; }
    public string? PhaseDevelopmentStart { get; set; }
    public string? PhaseMoveIn { get; set; }
    public string? PhasePlanning { get; set; }
    public string? PhaseSaleStart { get; set; }
}
