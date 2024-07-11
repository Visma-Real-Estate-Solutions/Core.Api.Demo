using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Case;

public class DocumentSigningDto
{
    /// <summary>
    /// Id of this model
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Guid of this model
    /// </summary>
    public required Guid Guid { get; set; }

    /// <summary>
    /// Signing name
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The confirmation file
    /// </summary>
    public Guid? SignedFileGuid { get; set; }

    /// <summary>
    /// The case this signing belong to
    /// </summary>
    public int CaseId { get; set; }

    /// <summary>
    /// The case guid this signing belongs to
    /// </summary>
    public Guid CaseGuid { get; set; }

    /// <summary>
    /// If this signing is completed
    /// </summary>
    public bool Completed { get; set; }

    /// <summary>
    /// Tasks
    /// </summary>
    public required IEnumerable<DocumentSigningTaskDto> Tasks { get; set; }

    /// <summary>
    /// Files
    /// </summary>
    public required IEnumerable<DocumentSigningFileDto> Files { get; set; }

    /// <summary>
    /// Signing methods available for the document signing
    /// </summary>
    public required IEnumerable<FileSigningType> FileSigningTypes { get; set; }
}

public class DocumentSigningFileDto
{
    /// <summary>
    /// The name of the file.
    /// </summary>
    public required string FileName { get; set; }

    /// <summary>
    /// The unique id of the file.
    /// </summary>
    public Guid FileGuid { get; set; }

    /// <summary>
    /// CaseId this file belong to
    /// </summary>
    public int? CaseId { get; set; }

    /// <summary>
    /// Is the file that is returned by Signicat viewable
    /// </summary>
    public bool IsSigningProofViewAvailable { get; set; }
}

/// <summary>
/// Representing signing process for a certain contact
/// </summary>
public class DocumentSigningTaskDto
{
    /// <summary>
    /// The date this task was signed
    /// </summary>
    public DateTimeOffset? SignedDate { get; set; }

    /// <summary>
    /// Status of the task
    /// </summary>
    public DocumentSigningTaskStatus? Status { get; set; }

    /// <summary>
    /// The contact task is for
    /// </summary>
    public int ContactId { get; set; }

    /// <summary>
    /// Entity ids on behalf of which the contact is signing the document
    /// </summary>
    public IEnumerable<int>? SigningOnBehalfOf { get; set; }

    /// <summary>
    /// Task guid
    /// </summary>
    public Guid Guid { get; set; }
}
