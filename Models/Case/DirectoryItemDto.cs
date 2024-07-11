using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Case;

public class FolderItemDto : DirectoryItemDto
{
    /// <summary>
    /// Unique folder type
    /// </summary>
    public UniqueFolderType UniqueFolderType { get; set; }

    /// <summary>
    /// True if the folder has content
    /// </summary>
    public bool HasContent { get; set; }

    /// <summary>
    /// True if the folder has any subfolders
    /// </summary>
    public bool HasSubFolder { get; set; }

    /// <summary>
    /// How many files exists in the folder (not including subfolders).
    /// </summary>
    public int FileCount { get; set; }
}

public class DirectoryItemDto
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
    public string? ParentUniqueFolderType { get; set; }

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
    public string? Name { get; set; }

    /// <summary>
    /// Item type
    /// </summary>
    public DirectoryItemType Type { get; set; }

    /// <summary>
    /// Describes who got access to this file
    /// </summary>
    public IEnumerable<string>? FileAccessRoles { get; set; }

    /// <summary>
    /// All file tag names related to the file
    /// </summary>
    public IEnumerable<string>? FileTags { get; set; }
}
