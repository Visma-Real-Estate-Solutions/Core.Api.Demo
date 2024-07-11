namespace CoreDemo.Models.Case;

public class CommonConditionsDto
{
    public int Id { get; set; }
    public decimal? Cost { get; set; }
    public decimal? NetCost { get; set; }
    public DateTime? CostVerifiedDate { get; set; }
    public string? CostIncludes { get; set; }
    public decimal? CostOperatingPart { get; set; }
    public decimal? CostCapitalPart { get; set; }
    public string? CommonCostComment { get; set; }
    public string? BusinessManagerComment { get; set; }
    public decimal? Fortune { get; set; }
    public DateTimeOffset? FortuneVerified { get; set; }
    public string? FortuneComment { get; set; }
    public decimal? TotalDebt { get; set; }
    public DateTimeOffset? TotalDebtValidated { get; set; }
    public string? TotalDebtComment { get; set; }
    public decimal? Debt { get; set; }
    public DateTimeOffset? DebtValidated { get; set; }
    public string? DebtComment { get; set; }
    public string? IndividualDownPaymentOfDebt { get; set; }
    [Obsolete("Use case roles")]
    public int? BusinessManagerId { get; set; }
    [Obsolete("Use case roles")]
    public int? ChairmanId { get; set; }
    [Obsolete("Use case roles")]
    public int? JointOwnershipId { get; set; }
    [Obsolete("Use case roles")]
    public int? CommonInsuranceId { get; set; }
    public string? InsurancePolicyNumber { get; set; }
    public string? FractionalBondNumber { get; set; }
    public decimal? FractionalBondAmount { get; set; }
    public bool? Preemption { get; set; }
    public string? PreemptionComment { get; set; }
    public string? CommunityOrginisation { get; set; }
    public string? SharedInsuranceComment { get; set; }
    public string? DebtLoanConditions { get; set; }
    public string? InterestOnlyComment { get; set; }
    [Obsolete("Use case roles")]
    public int? LandownerId { get; set; }
    [Obsolete("Use case roles")]
    public int? ElectricalCompanyId { get; set; }
    [Obsolete("Use case roles")]
    public int? WaterCompanyId { get; set; }
    [Obsolete("Use case roles")]
    public int? FireDepartmentId { get; set; }
    [Obsolete("Use case roles")]
    public int? RenovationCompanyId { get; set; }
    [Obsolete("Use case roles")]
    public int? AppraiserId { get; set; }
    [Obsolete("Use case roles")]
    public int? AppraisalCompanyId { get; set; }
    public DateTime? AppraisalDate { get; set; }
    public string? AppraisalConclusion { get; set; }
    public string? PropertyAppraisalReportComment { get; set; }
    [Obsolete("Use case roles")]
    public int? SellerBankId { get; set; }
    [Obsolete("Use case roles")]
    public int? BuyerBankId { get; set; }
    public string? GuaranteeSchemeDescription { get; set; }
    public string? SignificantInformation { get; set; }
    public decimal? CommunityOrganisationFee { get; set; }
    [Obsolete("Use case roles")]
    public int? CommunityOrganisationCompanyId { get; set; }
    [Obsolete("Use case roles")]
    public int? CountyGovernorId { get; set; }
    public int? CountyCouncilId { get; set; }
    public string? CommunityOrganizationEconomyAssessment { get; set; }
    [Obsolete("Use case roles")]
    public int? SuretyId { get; set; }
    [Obsolete("Use case roles")]
    public int? ManagerId { get; set; }
    public string? StipulatedRemoteWarming { get; set; }
    public decimal? PriceParkingLot { get; set; }
    public decimal? PriceStorage { get; set; }
    public decimal? PriceMiscellaneous { get; set; }
    public bool ParkingLotIncluded { get; set; }
    public bool StorageIncluded { get; set; }
    public bool MiscellaneousIncluded { get; set; }
    public decimal? ParkingCommissonBasis { get; set; }
    public decimal? StorageDocumentCostBasis { get; set; }
    public decimal? StartupCapital { get; set; }
    public string? BrokerCommissionComment { get; set; }
    public string? OfferedInsuranceComment { get; set; }
}
