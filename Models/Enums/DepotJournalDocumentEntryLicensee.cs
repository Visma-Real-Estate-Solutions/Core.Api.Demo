using System.ComponentModel;

namespace CoreDemo.Models.Enums;

/// <summary>
/// Depot journal document entry licensee
/// </summary>
public enum DepotJournalDocumentEntryLicensee
{
    /// <summary>
    /// Seller
    /// </summary>
    [Description("Selger")]
    Seller,

    /// <summary>
    /// Buyer
    /// </summary>
    [Description("Kjøper")]
    Buyer,

    /// <summary>
    /// Broker company
    /// </summary>
    [Description("Meglerfirmaet")]
    BrokerCompany,

    /// <summary>
    /// Other
    /// </summary>
    [Description("Annen")]
    Other,

    /// <summary>
    /// Bank
    /// </summary>
    [Description("Bank")]
    Bank,

    /// <summary>
    /// Surety, Surety bond, or guaranty
    /// </summary>
    [Description("Garantist")]
    Surety
}
