using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Case;

public class PropertyConditionsDto
{
    public decimal? AskingPrice { get; set; }
    public decimal? PublishedAskingPrice { get; set; }
    public decimal? CostForShowings { get; set; }
    public decimal? MortgageAmount { get; set; }
    public decimal? MinimumCommission { get; set; }
    public decimal? MaximumCost { get; set; }
    public decimal? FixedCommissionSum { get; set; }
    public decimal? FixedCommissionOfPriceInDecimals { get; set; }
    public decimal? CommissionOfSaleSumInDecimals { get; set; }
    public decimal? EstimatedHours { get; set; }
    public decimal? HourlyRate { get; set; }
    public bool? InvoiceExpensesAreIncluded { get; set; }
    public bool? MarketingPackageIsIncluded { get; set; }
    public decimal? SumBrokerCommission { get; set; }
    public string? CommissionDescription { get; set; }
    public decimal? TotalCost { get; set; }
    public CommissionType? CommissionType { get; set; }
    public List<PropertyConditionsCostsDto> Costs { get; set; } = new List<PropertyConditionsCostsDto>();
    public int? NumberOfShowings { get; set; }
    public decimal? AdvancePayment { get; set; }
    public bool IncludeCommonDebt { get; set; }
}
