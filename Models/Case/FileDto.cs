using CoreDemo.Models.Enums;
using CoreDemo.Models.Files;

namespace CoreDemo.Models.Case;

public class FileDto : DirectoryItem
{
    /// <summary>
    /// Media type, e.g "image/jpeg"
    /// </summary>
    public required string MimeType { get; set; }

    /// <summary>
    /// File size in bytes.
    /// </summary>
    public long Size { get; set; }

    /// <summary>
    /// SHA-1 hash value of the file data.
    /// </summary>
    public required string Hash { get; set; }

    /// <summary>
    /// File extension.
    /// </summary>
    public string? Extension { get; set; }
}

public abstract class DirectoryItem
{
    /// <summary>
    /// Unique item Id
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// ParentFolderId
    /// </summary>
    public Guid? ParentId { get; set; }

    /// <summary>
    /// Unique folder type of parent folder
    /// </summary>
    public UniqueFolderType? ParentUniqueFolderType { get; set; }

    /// <summary>
    /// Last modified date in UTC time zone
    /// </summary>
    public DateTimeOffset LastModifiedDate { get; set; }

    /// <summary>
    /// Id of the contact that last modified this item
    /// </summary>
    public int? LastModifiedById { get; set; }

    /// <summary>
    /// Item name
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Item type
    /// </summary>
    public required DirectoryItemType Type { get; set; }

    /// <summary>
    /// Describes who got access to this file
    /// </summary>
    public IEnumerable<FileAccessRoleDto>? FileAccessRoles { get; set; }

    /// <summary>
    /// All file tag names related to the file
    /// </summary>
    public IEnumerable<string>? FileTags { get; set; }
}
