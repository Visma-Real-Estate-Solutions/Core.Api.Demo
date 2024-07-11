namespace CoreDemo.Models.Admin;

public class MarketingIntegratorTokenDto
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? BrokerCompanyName { get; set; }

    public string? BrokerCompanyOrganizationNumber { get; set; }

    public int OfficeId { get; set; }

    public string? OfficeName { get; set; }

    public string? OfficeOrganizationNumber { get; set; }

    public int? CaseId { get; set; }

    public Dictionary<string, string>? Data { get; set; }
}
