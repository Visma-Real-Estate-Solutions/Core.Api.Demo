using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Integrations;

public class BankTransferDto
{
    /// <summary>
    /// The id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The case associated with the transfer.
    /// </summary>
    public int CaseId { get; set; }

    /// <summary>
    /// The id of the type of the bank transfer.
    /// </summary>
    public int BankTransferTypeId { get; set; }

    /// <summary>
    /// The id of the case client account to use.
    /// </summary>
    public int? CaseClientAccountId { get; set; }

    /// <summary>
    /// The amount to transfer.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// The date for the payment.
    /// </summary>
    public DateTimeOffset? PaymentDate { get; set; }

    /// <summary>
    /// A comment about the payment.
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// The status of the transfer.
    /// </summary>
    public BankTransferStatusType BankTransferStatus { get; set; }

    /// <summary>
    /// The customer to receive the transfer.
    /// </summary>
    public int? EntityId { get; set; }

    /// <summary>
    /// The name of the customer.
    /// </summary>
    public string? CustomerName { get; set; }

    /// <summary>
    /// The account number to receive the payment.
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    /// The kid number of the payment.
    /// </summary>
    public string? KidNumber { get; set; }

    /// <summary>
    /// A message sent with the payment.
    /// </summary>
    public string? Message1 { get; set; }

    /// <summary>
    /// A message sent with the payment.
    /// </summary>
    public string? Message2 { get; set; }

    /// <summary>
    /// A message sent with the payment.
    /// </summary>
    public string? Message3 { get; set; }

    /// <summary>
    /// The id of the employee who first created the bank transfer.
    /// </summary>
    public int? EmployeeId { get; set; }

    /// <summary>
    /// The id of the entry draft for the bank transfer.
    /// </summary>
    public int? EntryDraftId { get; set; }

    /// <summary>
    /// Entry number
    /// </summary>
    public int? EntryNumber { get; set; }

    /// <summary>
    /// A warning text describing if a bank transfer does not meet a specific rule set for a broker company.
    /// </summary>
    public string? WarningText { get; set; }

    /// <summary>
    /// The last error on this bank transfer if any.
    /// </summary>
    public string? LastError { get; set; }

    /// <summary>
    /// True if client account is used/required for this bank transfer
    /// </summary>
    public bool UseClientAccount { get; set; }

    /// <summary>
    /// The external reference, if the bank transfer was created by external sources/integrators.
    /// </summary>
    public string? ExternalReference { get; set; }

    /// <summary>
    /// Entity id of the client access user which was used to create this bank transfer.
    /// If it is not null that means that this entry was created by external sources (by integrators).
    /// </summary>
    public int? ClientAccessUserEntityId { get; set; }
}
