namespace CoreDemo.Models.Case;

public class BuildingDto
{
    public string? Description { get; set; }
    public string? Information { get; set; }
    /// <summary>
    /// Floor space (BRA)
    /// </summary>
    public decimal FloorSpace { get; set; }
    public string? FloorSpacePerFloor { get; set; }
    /// <summary>
    /// Primary room (P-ROM)
    /// </summary>
    public decimal PrimaryRoomSpace { get; set; }
    /// <summary>
    /// BRA-i (Internt bruksareal)
    /// Bruksareal av boenheten innenfor omsluttede vegger.
    /// </summary>
    public decimal? GrossInternalArea { get; set; }
    /// <summary>
    /// BRA-i (Internt bruksareal)
    /// In case of a construction where this is yet decided, the upper limit.
    /// </summary>
    public decimal? GrossInternalAreaTo { get; set; }
    /// <summary>
    /// BRA-e (Eksternt bruksareal)
    /// Bruksareal av alle rom som ligger utenfor boenheten/boenhetene, men som tilhører denne/disse.
    /// </summary>
    public decimal? GrossExternalArea { get; set; }
    /// <summary>
    /// BRA-e til (Eksternt bruksareal)
    /// In case of a construction where this is yet decided, the upper limit.
    /// </summary>
    public decimal? GrossExternalAreaTo { get; set; }
    /// <summary>
    /// BRA-b (Innglasset balkong)
    /// Bruksareal av innglasset balkong tilknyttet boenheten.
    /// </summary>
    public decimal? EnclosedBalconyArea { get; set; }
    /// <summary>
    /// BRA-b til (Innglasset balkong)
    /// In case of a construction where this is yet decided, the upper limit.
    /// </summary>
    public decimal? EnclosedBalconyAreaTo { get; set; }
    /// <summary>
    /// Åpent Areal
    /// Areal av terrasser og åpne balkonger tilknyttet boenheten (også åpen veranda eller altan).
    /// </summary>
    public decimal? OpenArea { get; set; }
    /// <summary>
    /// Åpent Areal til
    /// In case of a construction where this is yet decided, the upper limit.
    /// </summary>
    public decimal? OpenAreaTo { get; set; }
    public string? PrimaryRoomSpacePerFloor { get; set; }
    public string? IncludedInPrimaryRoomSpace { get; set; }
    /// <summary>
    /// Gross floor space (BTA)
    /// Deprecated
    /// </summary>
    public decimal GrossFloorSpace { get; set; }
    /// <summary>
    /// Areal fra (næring)
    /// </summary>
    public decimal? AreaFrom { get; set; }
    /// <summary>
    /// Areal til (næring)
    /// In case of a construction where this is yet decided, the upper limit.
    /// </summary>
    public decimal? AreaTo { get; set; }
    public int? BuiltYear { get; set; }
    public string? BuiltYearAccordingTo { get; set; }
    public int? ExpansionBuiltYear { get; set; }
    public int MarketValue { get; set; }
    public int LoanValue { get; set; }
    public decimal? NumberOfRooms { get; set; }
    public decimal NumberOfBedrooms { get; set; }
    public decimal? NumberOfBeds { get; set; }
    public decimal? NumberOfBathrooms { get; set; }
    public string? BuildingNumber { get; set; }
    public string? BuildingName { get; set; }
    public string? EnergyLabel { get; set; }
    public string? EnergyLabelDescription { get; set; }
    public string? HeatingGrade { get; set; }
    public int? Storey { get; set; }
    public int? StoreyOf { get; set; }
    public bool? IsBasement { get; set; }
    public string? BuildingComment { get; set; }
    /// <summary>
    /// Size of the outdoor area in m2
    /// </summary>
    public decimal? OutdoorAreaSize { get; set; }
    /// <summary>
    /// Size of the total floor area in m2
    /// </summary>
    public decimal? TotalFloorArea { get; set; }
    /// <summary>
    /// Size of the low ceiling height area in m2
    /// </summary>
    public decimal? LowCeilingArea { get; set; }
}
