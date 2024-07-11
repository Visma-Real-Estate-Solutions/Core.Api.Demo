namespace CoreDemo.Models.Integrations;

/// <summary>
/// Bank transfer type model
/// </summary>
public class BankTransferTypeDto
{
    /// <summary>
    /// The bank transfer type id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The bank transfer type name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The organization number of the broker company for which this bank transfer type is defined
    /// </summary>
    public string? BrokerCompanyOrganizationNumber { get; set; }
}
