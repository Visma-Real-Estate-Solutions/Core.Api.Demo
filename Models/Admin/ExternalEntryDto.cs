namespace CoreDemo.Models.Admin;

/// <summary>
/// Entry from external accounting systems.
/// </summary>
public class ExternalEntryDto
{
    /// <summary>
    /// The unique id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The id of the case
    /// </summary>
    public int CaseId { get; set; }

    /// <summary>
    /// Address + referral key
    /// </summary>
    public string? CaseName { get; set; }

    /// <summary>
    /// The id of the entity that created the entry.
    /// </summary>
    public int? CreatedById { get; set; }

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
    /// Additional information about the entry.
    /// </summary>
    public string? Info { get; set; }

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

    /// <summary>
    /// The id of an entry created based on this external entry if the entry exist.
    /// </summary>
    public int? EntryId { get; set; }

    /// <summary>
    /// The id of an entry draft created based on this external entry if the entry draft exist.
    /// </summary>
    public int? EntryDraftId { get; set; }

    /// <summary>
    /// An optional URL for more information about the external entry.
    /// </summary>
    public IEnumerable<string> Urls { get; set; } = new List<string>();

    /// <summary>
    /// This external entry should not be used for accounting.
    /// </summary>
    public bool SkipAccounting { get; set; }
}
