namespace CoreDemo.Models.Enums;

/// <summary>
/// State type
/// </summary>
public enum MarketingIntegratorOrderStateType
{
    /// <summary>
    /// Ukjent
    /// </summary>
    Unknown,

    /// <summary>
    /// Opprettet
    /// </summary>
    CreatedNotSent,

    /// <summary>
    /// Under behandling
    /// </summary>
    InProcess,

    /// <summary>
    /// Feil
    /// </summary>
    Error,

    /// <summary>
    /// Manglende info
    /// </summary>
    MissingInfo,

    /// <summary>
    /// Ferdig
    /// </summary>
    Completed,

    /// <summary>
    /// Kansellert
    /// </summary>
    Cancelled,

    /// <summary>
    /// Opprettet
    /// </summary>
    Created,

    /// <summary>
    /// Aktivert
    /// </summary>
    Activated
}
