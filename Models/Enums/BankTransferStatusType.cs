namespace CoreDemo.Models.Enums;

public enum BankTransferStatusType
{
    /// <summary>
    /// Kladd
    /// </summary>
    Hold,

    /// <summary>
    /// Klar
    /// </summary>
    Ready,

    /// <summary>
    /// Sender til bank
    /// </summary>
    Exporting,

    /// <summary>
    /// Utbetalt
    /// </summary>
    Paid,

    /// <summary>
    /// Feilet
    /// </summary>
    Failed,

    /// <summary>
    /// Venter på å bli signert
    /// </summary>
    PendingApproval,

    /// <summary>
    /// Avvist
    /// </summary>
    Rejected,

    /// <summary>
    /// (ISO 20022) Mottatt av bank
    /// </summary>
    ReceivedByBank,

    /// <summary>
    /// (ISO 20022) Bekreftet av bank
    /// </summary>
    VerifiedByBank,

    /// <summary>
    /// (ISO 20022) Krav ikke møtt / kan trenge behandling av bank eller bruker
    /// </summary>
    PendingAtBank
}
