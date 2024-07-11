using CoreDemo.Models.Admin;

namespace CoreDemo.Models.Requests;

public class MarketingIntegratorOrderMetadataRequest
{
    public string? Title { get; set; }
    public string? ActionText { get; set; }
    public IEnumerable<MarketingIntegratorMetadataDto>? Metadata { get; set; }
}
