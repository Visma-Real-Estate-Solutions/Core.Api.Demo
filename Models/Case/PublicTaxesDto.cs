using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Case;

public class PublicTaxesDto
{
    public decimal? LocalTaxes { get; set; }
    public decimal? LocalTaxesYear { get; set; }
    public decimal? LocalTaxesInterval { get; set; }
    public decimal? LocalTaxesRearage { get; set; }
    public decimal? RenovationTaxes { get; set; }
    public decimal? RenovationTaxesYear { get; set; }
    public decimal? RenovationTaxesInterval { get; set; }
    public decimal? RenovationTaxesRearage { get; set; }
    public decimal? PrimaryPropertyTaxValue { get; set; }
    public decimal? SecondaryPropertyTaxValue { get; set; }
    public decimal? PropertyTax { get; set; }
    public decimal? PropertyTaxValueYear { get; set; }
    public decimal? PropertyTaxAssesedValue { get; set; }
    public string? ServicesCommentPropertyTax { get; set; }
    public decimal? ServicesFeeSanitation { get; set; }
    public decimal? ServicesFeeWater { get; set; }
    public decimal? ServicesFeeSewer { get; set; }
    public string? ServicesCommentLocalTaxes { get; set; }
    public string? FixedOngoingCostsComment { get; set; }
    public string? ConnectionFeesComment { get; set; }
    public decimal? DocumentCostBasis { get; set; }
    public ChargeBasisType? ChargeBasisType { get; set; }
    public bool DocumentCostBasisDiffersFromOriginalCalculation { get; set; }
    public decimal? InsurancePremiumBuilding { get; set; }
    public decimal? ElectricityConsumption { get; set; }
    public decimal? ConsumptionOfOtherHeatSources { get; set; }
    public string? WaterMeter { get; set; }
    public decimal? SweepingFees { get; set; }
    public decimal? WaterFees { get; set; }
    public decimal? RoadFees { get; set; }
    public string? RenovationComments { get; set; }
    public string? OtherCosts { get; set; }
}
