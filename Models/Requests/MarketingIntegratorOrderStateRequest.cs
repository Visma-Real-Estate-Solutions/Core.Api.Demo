using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Requests;

public class MarketingIntegratorOrderStateRequest
{
    public MarketingIntegratorOrderStateType? State { get; set; }

    public string? Status { get; set; }
}
