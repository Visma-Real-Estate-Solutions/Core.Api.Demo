namespace CoreDemo.Models.Contacts;

/// <summary>
/// revenuel journal annotation model
/// </summary>
public class RevenueJournalAnnotationDto
{
    /// <summary>
    /// annotation date
    /// </summary>
    public DateTimeOffset AnnotationDate { get; set; }
    /// <summary>
    /// annotation
    /// </summary>
    public string? Annotation { get; set; }

    /// <summary>
    /// payment change
    /// </summary>
    public decimal? PaymentChange { get; set; }
}
