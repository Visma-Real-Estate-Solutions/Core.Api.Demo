namespace CoreDemo.Models.Economics;

/// <summary>
/// Description of an entry definition model
/// Often referred to as 'Bilagstype' in norwegian
/// </summary>
public class EntryDefinitionDto
{
    /// <summary>
    /// Unique identifier of an entry definition model
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The name of the entry defintion
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The suggested text to use in the comment of the entry or entrydraft.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The default amount for the entrydefinition.
    /// </summary>
    public decimal DefaultAmount { get; set; }

    /// <summary>
    /// Value Added Tax
    /// </summary>
    public double? VAT { get; set; }

    /// <summary>
    /// Identifier of the credit account
    /// </summary>
    public int CreditAccountId { get; set; }

    /// <summary>
    /// Identifier of the debit account
    /// </summary>
    public int DebitAccountId { get; set; }
}
