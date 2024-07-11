namespace CoreDemo.Models.Requests;

/// <summary>
/// Request sendt to get the sumModel From a set Time
/// </summary>
public class RevenueJournalSumRequest
{
    /// <summary>
    /// From date of the journal that will be calculated
    /// </summary>
    public DateTimeOffset? FromDate { get; set; }

    /// <summary>
    /// To date of the journal that will be calculated
    /// </summary>
    public DateTimeOffset? ToDate { get; set; }
}
