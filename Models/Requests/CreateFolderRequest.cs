namespace CoreDemo.Models.Requests;

public class CreateFolderRequest
{
    /// <summary>
    /// Name of the folder you want to create.
    /// </summary>
    public required string Name { get; set; }

    public required string Type { get; set; }
}
