using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Files;

public class FileAccessRoleDto
{
    /// <summary>
    /// Unique Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The role the file will be shared to.
    /// </summary>
    public CaseRoleType CaseRole { get; set; }

    /// <summary>
    /// FileId of the file to share.
    /// </summary>
    public Guid FileId { get; set; }

    /// <summary>
    /// The date this file got shared with the spesific role.
    /// </summary>
    public DateTimeOffset? SharedDate { get; set; }
}
