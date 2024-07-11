namespace CoreDemo.Models.Case;

public class ResidenceDto
{
    public string? AllodialRights { get; set; }
    public string? Concession { get; set; }
    public string? ResidenceRequirements { get; set; }
    public string? OperationalRequirements { get; set; }
    public int AreaId { get; set; }
    public string? AreaInMarketing { get; set; }
    /// <summary>
    /// Coop number in case the residence is part of a housing association
    /// Andel i borettslag
    /// </summary>
    public int? CooperativeNumber { get; set; }
    public string? HousingAssociationComments { get; set; }
    /// <summary>
    /// Askjenummer
    /// </summary>
    public string? BondNumber { get; set; }
    public decimal BondAmount { get; set; }
    public string? ApartmentNumber { get; set; }
    public int? ProjectBuildingNumber { get; set; }
}
