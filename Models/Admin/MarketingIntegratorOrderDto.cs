namespace CoreDemo.Models.Admin;

public class MarketingIntegratorOrderDto
{
    public int Id { get; set; }

    public Guid Guid { get; set; }

    public string? Title { get; set; }

    public string? ActionText { get; set; }

    public int CaseBaseId { get; set; }

    public int MarketingIntegratorId { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }

    public string? Metadata { get; set; }

    public IEnumerable<MarketingIntegratorOrderStatusDto>? OrderStatuses { get; set; }
}
