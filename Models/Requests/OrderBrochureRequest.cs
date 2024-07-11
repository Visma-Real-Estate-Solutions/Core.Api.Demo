using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Requests;

public class OrderBrochureRequest
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
    /// Email.
    /// </summary>
    public required string Email { get; set; }

    /// <summary>
    /// The country prefix associated with the phonenumber.
    /// </summary>
    public string? CountryPrefix { get; set; }

    /// <summary>
    /// Telephone number.
    /// </summary>
    public string? Telephone { get; set; }

    /// <summary>
    /// Additional comments.
    /// </summary>
    public string? Comments { get; set; }

    /// <summary>
    /// Consents that are checked
    /// </summary>
    public List<Guid>? CheckedConsents { get; set; }

    /// <summary>
    /// Processingbases that are checked
    /// </summary>
    public List<Guid>? CheckedProcessingBases { get; set; }

    /// <summary>
    /// What language should registration notification be sent in.
    /// </summary>
    public LanguageType? NotificationLanguage { get; set; }
}

