namespace CoreDemo.Models.Admin;

public class DynamicSaleTextMergedItemDto
{
    /// <summary>
    /// The dynamic sale text definition id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The parent header id as it appears on the case (skipping the groups)
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// The Header text
    /// </summary>
    public string? Header { get; set; }

    /// <summary>
    /// The text template
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// The header level (H1, H2, ...)
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// True if this item should not be published on the internet. False otherwise.
    /// </summary>
    public bool ShouldNotBePublished { get; set; }

    /// <summary>
    /// Error Message, if there are any errors in Header or TextTemplate
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// Boolean value indicating if there are any errors in Header or TextTemplate
    /// </summary>
    public bool HasError { get; set; }

    /// <summary>
    /// Date and time when the item was created or last updated
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}
