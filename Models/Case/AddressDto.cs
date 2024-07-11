namespace CoreDemo.Models.Case;

public class AddressDto
{
    public int Id { get; set; }
    public int? EntityBaseId { get; set; }
    public int? CityId { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }
    public string? City { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public bool IsPreferred { get; set; }
    /// <summary>
    /// True if not in norway
    /// </summary>
    public bool IsAbroad { get; set; }
}
