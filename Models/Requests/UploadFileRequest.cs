namespace CoreDemo.Models.Requests;

public class UploadFileRequest
{
    /// <summary>
    /// File name.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The media description.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// The id of the category to assign to the given file.
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// A list ids of the tags to assign to the given file.
    /// </summary>
    public IEnumerable<int>? TagIds { get; set; }

    /// <summary>
    /// A list categories of the tags to assign to the given file.
    /// </summary>
    public IEnumerable<string>? TagCategories { get; set; }

    /// <summary>
    /// Export to Finn. Only works for files in Attachment-folder
    /// </summary>
    public bool Export { get; set; }

    /// <summary>
    /// Export to RES
    /// </summary>
    public bool ExportRes { get; set; }
}
