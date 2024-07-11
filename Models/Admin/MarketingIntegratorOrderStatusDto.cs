using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Admin;

public class MarketingIntegratorOrderStatusDto
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public MarketingIntegratorOrderStateType OrderStateType { get; set; }

    public DateTimeOffset CreatedDate { get; set; }
}
