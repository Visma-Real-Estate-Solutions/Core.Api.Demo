namespace CoreDemo.Models.Enums;

public enum OwnershipType
{
    /// <summary>
    /// Ukjent
    /// </summary>
    Unknown,

    /// <summary>
    /// Fast eiendom
    /// </summary>
    Freehold,

    /// <summary>
    /// Andel
    /// </summary>
    Share,

    /// <summary>
    /// Aksje
    /// </summary>
    Stock,

    /// <summary>
    /// Festet
    /// </summary>
    [Obsolete]
    Lease,

    /// <summary>
    /// Obligasjon
    /// </summary>
    Bond,

    /// <summary>
    /// Eierseksjon
    /// </summary>
    Condominium
}
