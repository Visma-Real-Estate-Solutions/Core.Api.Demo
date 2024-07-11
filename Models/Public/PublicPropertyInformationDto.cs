using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Public;

/// <summary>
/// Contains publicly available property information.
/// </summary>
public class PublicPropertyInformationDto
{
    /// <summary>
    /// The name of the office the given property is connected to.
    /// </summary>
    public string? OfficeName { get; set; }

    /// <summary>
    /// The guid of the broker for this property.
    /// </summary>
    public Guid BrokerGuid { get; set; }

    /// <summary>
    /// The name of the broker for this property.
    /// </summary>
    public string? BrokerName { get; set; }

    /// <summary>
    /// The phone number of the broker for this property.
    /// </summary>
    public string? BrokerPhone { get; set; }

    /// <summary>
    /// The address for this property.
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// The property description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The asking price.
    /// </summary>
    public decimal? AskingPrice { get; set; }

    /// <summary>
    /// Specifies whether or not the property has been sold.
    /// </summary>
    public bool IsSold { get; set; }

    /// <summary>
    /// Number of rooms
    /// </summary>
    public int NumberOfRooms { get; set; }

    /// <summary>
    /// Name of municipality
    /// </summary>
    public string? Municipality { get; set; }

    /// <summary>
    /// Name of city
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Type of case (CaseCategoryType)
    /// </summary>
    public CaseCategoryType CaseCategoryType { get; set; }
}
