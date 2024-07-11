using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Requests;

/// <summary>
/// Used to create a stakeholder without a contact id.
/// </summary>
public class AnonymousCreateStakeholderRequest
{
    /// <summary>
    /// First name.
    /// </summary>
    public required string FirstName { get; set; }

    /// <summary>
    /// Last name.
    /// </summary>
    public required string SurName { get; set; }

    /// <summary>
    /// Email address.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// The country prefix associated with the phonenumber.
    /// </summary>
    public string? CountryPrefix { get; set; }

    /// <summary>
    /// Telephone number.
    /// </summary>
    public string? Telephone { get; set; }

    /// <summary>
    /// Owns the house
    /// </summary>
    public bool OwnsHousing { get; set; }

    /// <summary>
    /// Want funding
    /// </summary>
    public bool WantFunding { get; set; }

    /// <summary>
    /// Comments
    /// </summary>
    public string? Comments { get; set; }

    /// <summary>
    /// Consents that are checked
    /// </summary>
    public List<Guid> CheckedConsents { get; set; } = new List<Guid>();

    /// <summary>
    /// ProcessingBases that are checked
    /// </summary>
    public List<Guid> CheckedProcessingBases { get; set; } = new List<Guid>();

    /// <summary>
    /// Contact method type
    /// </summary>
    public ContactMethodType? ContactMethodType { get; set; }

    /// <summary>
    /// If a private showing is requested
    /// </summary>
    public bool PrivateShowing { get; set; }

    /// <summary>
    /// If true the default email will not be sent.
    /// </summary>
    public bool PreventDefaultEmail { get; set; }

    /// <summary>
    /// Which showing activity should the contact be added to as a participant
    /// </summary>
    public Guid? ShowingActivityGuid { get; set; }

    /// <summary>
    /// If set (in combination with ProcessingBasisSystemType), the latest of the appropriate processing bases will be added for stakeholders
    /// </summary>
    public ProcessingBasisCategoryType? ProcessingBasisCategory { get; set; }

    /// <summary>
    /// If set (in combination with ProcessingBasisCategory), the latest of the appropriate processing bases will be added for stakeholders
    /// </summary>
    public ProcessingBasisSystemType? ProcessingBasisSystemType { get; set; }

    /// <summary>
    /// How many participants will attend showing including stakeholder
    /// </summary>
    public int? NumberOfParticipants { get; set; }

    /// <summary>
    /// What language should registration notification be sent in.
    /// </summary>
    public LanguageType? NotificationLanguage { get; set; }
}
