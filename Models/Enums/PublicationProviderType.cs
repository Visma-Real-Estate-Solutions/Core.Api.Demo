namespace CoreDemo.Models.Enums;

/// <summary>
/// Publication provider type
/// </summary>
public enum PublicationProviderType
{
    /// <summary>
    /// Unknown provider (must be 0)
    /// </summary>
    Unknown,

    /// <summary>
    /// [Norway] finn.no (https://finn.no)
    /// </summary>
    Finn,

    /// <summary>
    /// [Norway] Eiendomsnett (http://amedia.no)
    /// </summary>
    Eiendomsnett,

    /// <summary>
    /// WRE home page API
    /// </summary>
    WreHome,

    /// <summary>
    /// Updates models locally
    /// </summary>
    LocalProvider,

    /// <summary>
    /// [Norway] Hjem.no (https://hjem.no)
    /// </summary>
    Hjem,

    /// <summary>
    /// [Norway] Boligpartner
    /// </summary>
    Boligpartner,

    /// <summary>
    /// [Norway] Boligpartner boligfelt
    /// </summary>
    BoligpartnerLargeProject,

    /// <summary>
    /// [Norway] finn.no (https://finn.no) coming for sale
    /// </summary>
    FinnComingForSale
}
