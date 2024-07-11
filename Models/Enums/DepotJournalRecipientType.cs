namespace CoreDemo.Models.Enums;

/// <summary>
/// Depot journal document recipient
/// </summary>
public enum DepotJournalRecipientType
{
    /// <summary>
    /// None
    /// </summary>
    None,

    /// <summary>
    /// Seller
    /// </summary>
    Seller, // Selger

    /// <summary>
    /// Buyer
    /// </summary>
    Buyer, // kjøper

    /// <summary>
    /// Bank
    /// </summary>
    Bank,

    /// <summary>
    /// Settlement Office
    /// </summary>
    SettlementOffice, // oppgjørsavdeling

    /// <summary>
    /// Broker Office
    /// </summary>
    BrokerOffice, // megleravdeling

    /// <summary>
    /// Official registration
    /// </summary>
    OfficialRegistration, // Tinglysning

    /// <summary>
    /// Other
    /// </summary>
    Other, // annen
}
