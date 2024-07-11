namespace CoreDemo.Models.Requests;

/// <summary>
/// Represents a bank transfer request.
/// Can be used for Create or Update.
/// Note that some fields are required when creating a bank transfer, and not nullable as presented here. (For patch convenience)
/// </summary>
public class BankTransferRequest
{
    /// <summary>
    /// The bank transfer type id
    /// Required when creating a banktransfer
    /// </summary>
    public int? BankTransferTypeId { get; set; }

    /// <summary>
    /// The amount to transfer.
    /// </summary>
    public decimal? Amount { get; set; }

    /// <summary>
    /// The date for the payment.
    /// </summary>
    public DateTimeOffset? PaymentDate { get; set; }

    /// <summary>
    /// A comment about the transfer.
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// The Identification number of receiver of the payment. Organisation number if the receiver is a company, personal number if it is a person.
    /// Required when creating a banktransfer
    /// </summary>
    public string? ReceiverIdentificationNumber { get; set; }

    /// <summary>
    /// The name of receiver of the payment
    /// Required if the receiver is not registered in the system.
    /// </summary>
    public string? ReceiverName { get; set; }

    /// <summary>
    /// True if the receiver of the payment is a company or organization.
    /// </summary>
    public bool? ReceiverIsACompany { get; set; }

    /// <summary>
    /// The account number to receive the payment.
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    /// The kid number of the payment.
    /// </summary>
    public string? KidNumber { get; set; }

    /// <summary>
    /// The external/integrator's reference.
    /// </summary>
    public string? ExternalReference { get; set; }
}
