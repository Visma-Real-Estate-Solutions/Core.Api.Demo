namespace CoreDemo.Models.Enums;

public enum EmailRecipientType
{
    /// <summary>
    /// Recipient will be added in the "To" field of the email.
    /// </summary>
    To,

    /// <summary>
    /// Recipient will be added in the "Copy" field of the email.
    /// </summary>
    Cc,

    /// <summary>
    /// The recipient will be added in the "Blind copy" field of the email.
    /// </summary>
    Bcc
}
