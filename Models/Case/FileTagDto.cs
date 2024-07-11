using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Case;

public class FileTagDto
{
    /// <summary>
    /// The file tag identificator.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The file tag name.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// If this file tag is a system tag
    /// </summary>
    public bool IsSystemTag { get; set; }

    /// <summary>
    /// File tag category type
    /// </summary>
    public required SystemFileTagCategoryType CategoryType { get; set; }

    /// <summary>
    /// Last time this tag was modified
    /// </summary>
    public DateTimeOffset? LastModifiedDate { get; set; }

    /// <summary>
    /// An array of CaseRoles to be shared the file with
    /// </summary>
    public IEnumerable<string>? CaseRoleTypes { get; set; }

    /// <summary>
    /// An array of authorization role ids to share a file with this tag with
    /// </summary>
    public IEnumerable<int>? AuthorizationRoleIds { get; set; }
}
