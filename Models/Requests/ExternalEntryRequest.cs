namespace CoreDemo.Models.Requests;

/// <summary>
/// Request for creating an entry from external accounting systems.
/// </summary>
public class ExternalEntryRequest
{
    /// <summary>
    /// The id of the case
    /// </summary>
    public int CaseId { get; set; }

    /// <summary>
    /// The entry number in the external accounting system.
    /// </summary>
    public int EntryNumber { get; set; }

    /// <summary>
    /// The name of the supplier.
    /// </summary>
    public string? SupplierName { get; set; }

    /// <summary>
    /// A comment describing the entry.
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// The date the entry was posted in.
    /// </summary>
    public DateTimeOffset? PostingDate { get; set; }

    /// <summary>
    /// The date of the entry.
    /// </summary>
    public DateTimeOffset? EntryDate { get; set; }

    /// <summary>
    /// The amount.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// The number of the debit account.
    /// </summary>
    public int? DebitNumber { get; set; }

    /// <summary>
    /// The number of the credit account.
    /// </summary>
    public int? CreditNumber { get; set; }

    /// <summary>
    /// The id of the entry definition to use if creating an entry or entry draft from this external entry.
    /// </summary>
    public int? EntryDefinitionId { get; set; }

    // To be added later.
    ///// <summary>
    ///// If an entry has been created based on this external entry.
    ///// </summary>
    //public bool IsEntryCreated { get; set; }

    /// <summary>
    /// An optional URL for more information about the external entry.
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// If an entry draft should be created (EntryDefinitionId is required if this field is true).
    /// </summary>
    public bool CreateEntryDraft { get; set; }

    /// <summary>
    /// If an entry should be created (EntryDefinitionId is required if this field is true).
    /// </summary>
    public bool CreateEntry { get; set; }
}
