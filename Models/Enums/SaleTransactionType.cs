namespace CoreDemo.Models.Enums;

/// <summary>
/// Sale transaction type
/// https://www.ssb.no/klass/klassifikasjoner/21
/// </summary>
public enum SaleTransactionType
{
    /// <summary>
    /// Fritt salg
    /// </summary>
    FreeSale,

    /// <summary>
    /// Gave
    /// </summary>
    Gift,

    /// <summary>
    /// Eksprop
    /// </summary>
    Expropriation,

    /// <summary>
    /// Tvangssalg
    /// </summary>
    ForcedSale,

    /// <summary>
    /// Uskifte
    /// </summary>
    ImmovablePermit,

    /// <summary>
    /// Skifte
    /// </summary>
    ProbateSettlement,

    /// <summary>
    /// OpphSamb
    /// </summary>
    OpphSamb,

    /// <summary>
    /// Annet
    /// </summary>
    Other
}
