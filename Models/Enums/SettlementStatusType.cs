namespace CoreDemo.Models.Enums;

/// <summary>
/// The status for handling property after it have been sold
/// </summary>
/// <summary>
/// The status for handling property after it have been sold
/// </summary>
public enum SettlementStatusType
{
    /// <summary>
    /// Venter
    /// </summary>
    Waiting,

    General,

    /// <summary>
    /// Overført til oppgjør
    /// </summary>
    TransferredToSettlement,

    /// <summary>
    /// Mottatt oppgjør
    /// </summary>
    SettlementReceived,

    /// <summary>
    /// Skjøte sendt til tinglysning
    /// </summary>
    DeedSentToRegistration,

    /// <summary>
    /// Klar til oppgjør
    /// </summary>
    ReadyForSettlement,

    /// <summary>
    /// Oppgjør gjennomført
    /// </summary>
    SettlementCompleted,

    /// <summary>
    /// Arkivert
    /// </summary>
    Archived
}
