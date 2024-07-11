namespace CoreDemo.Models.Search;

public class ContactSearchDto
{
    public int Id { get; set; }
    public string? ExternalId { get; set; }
    public bool CustomerWebUser { get; set; }
    public bool Active { get; set; }
    public bool IsPublic { get; set; }
    public bool IsProfessional { get; set; }
    public bool IsActiveSeller { get; set; }
    public bool IsLead { get; set; }
    public IEnumerable<int> LeadCaseIds { get; set; } = new List<int>();
    public int ChainId { get; set; }
    public int? BrokerCompanyId { get; set; }
    public string? Name { get; set; }
    public string? FirstName { get; set; }
    public string? SurName { get; set; }
    public string? MatchName { get; set; }
    public string? PrimaryImageId { get; set; }
    public string? Email { get; set; }
    public IEnumerable<string> Emails { get; set; } = new List<string>();

    public string? PhoneNumber { get; set; }
    public IEnumerable<string> PhoneNumbers { get; set; } = new List<string>();
    public IEnumerable<string> SearchablePhoneNumbers { get; set; } = new List<string>();
    public string? Address { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }
    public string? City { get; set; }
    public IEnumerable<string> Addresses { get; set; } = new List<string>();
    public string? Municipality { get; set; }
    public IEnumerable<string> Functions { get; set; } = new List<string>();
    public bool IsDNumber { get; set; }
    public string? ContactType { get; set; }
    public IEnumerable<string> RoleType { get; set; } = new List<string>();
    public DateTimeOffset? LastOpenedDate { get; set; }
    public string? JobTitle { get; set; }
    public bool SkipAmlMonitoring { get; set; }
    public string? SearchType { get; set; }
    public DateTimeOffset? LastIndexed { get; set; }
    public DateTimeOffset? LastModifiedDate { get; set; }
    public string? Guid { get; set; }
    public string? Type { get; set; }
    public string? IdentificationNumber { get; set; }
}
