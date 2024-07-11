using System.ComponentModel;

namespace CoreDemo.Models.Enums;

/// <summary>
/// Depot journal deocument type
/// </summary>
public enum DepotJournalDocumentStatusType
{
    /// <summary>
    /// None
    /// </summary>
    None,

    /// <summary>
    /// Received
    /// </summary>
    [Description("Mottatt")] Received,

    /// <summary>
    /// Sent
    /// </summary>
    [Description("Sendt")] Sent,

    /// <summary>
    /// completed document
    /// </summary>
    [Description("Avsluttet dokument")] CompletedDocument,

    /// <summary>
    /// Reopened
    /// </summary>
    [Description("Gjenåpnet")] Reopened,

    /// <summary>
    /// Received from official registration
    /// </summary>
    [Description("Mottatt fra tinglysning")]
    ReceivedFromOfficialRegistration,

    /// <summary>
    /// Completed electronically
    /// </summary>
    [Description("Avsluttet elektronisk")] CompletedElectronically,

    /// <summary>
    /// Rejected
    /// </summary>
    [Description("Avvist")] Rejected
}
