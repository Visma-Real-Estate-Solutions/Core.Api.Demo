using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Public;

/// <summary>
/// Represents the processing basis base.
/// </summary>
public class ProcessingBasisBase
{
    /// <summary>
    /// Processing basis Guid.
    /// </summary>
    public Guid Guid { get; set; }

    /// <summary>
    /// Processing basis description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Extended processing basis description. Intended to be displayed when a processing basis have been checked in a showing form.
    /// </summary>
    public string? ExtendedDescription { get; set; }

    /// <summary>
    /// Processing basis version.
    /// </summary>
    public decimal Version { get; set; }

    /// <summary>
    /// Processing basis category type.
    /// </summary>
    public ProcessingBasisCategoryType CategoryType { get; set; }

    /// <summary>
    /// Processing basis type.
    /// </summary>
    public ProcessingBasisType Type { get; set; }

    /// <summary>
    /// Processing basis system type.
    /// </summary>
    public ProcessingBasisSystemType SystemType { get; set; }

    /// <summary>
    /// Where to display the processing basis
    /// </summary>
    public IEnumerable<ProcessingBasisDisplayType>? DisplayTypes { get; set; }

    /// <summary>
    /// Is processing basis active. If it isn't it will not be possible for contacts to consent to it.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Whether or not a contact who has consented to this processing basis can be contacted.
    /// </summary>
    public bool CanBeContacted { get; set; }

    /// <summary>
    /// If true, only users with processing basis admin or processing basis delete can remove processing basis relations connected to this processing basis
    /// </summary>
    public bool RequireDeletePermission { get; set; }

    /// <summary>
    /// CaseStatus that the contact related to this consent gets hidden.
    /// </summary>
    public CaseStatusType? HideOnStatus { get; set; }

    /// <summary>
    /// Delay the hiding of the contact by a specific number of milliseconds after the CaseStatus is reached.
    /// </summary>
    public long? DelayHideOnStatusMs { get; set; }

    /// <summary>
    /// The hiding delay in timespan
    /// </summary>
    public TimeSpan? DelayHideOnStatusTimeSpan { get; set; }

    /// <summary>
    /// If the contact is to be hidden after a set of days.
    /// </summary>
    public int? HideAfterDays { get; set; }

    /// <summary>
    /// CaseStatus that the contact related to this consent gets deleted.
    /// </summary>
    public CaseStatusType? DeleteOnStatus { get; set; }

    /// <summary>
    /// Delay the deletion of the contact by a specific number of milliseconds after the CaseStatus is reached.
    /// </summary>
    public long? DelayDeleteOnStatusMs { get; set; }

    /// <summary>
    /// The delete delay in timespan
    /// </summary>
    public TimeSpan? DelayDeleteOnStatusTimeSpan { get; set; }

    /// <summary>
    /// If the contact is to be deleted after a set of days.
    /// </summary>
    public int? DeleteAfterDays { get; set; }
}

/// <summary>
/// Represents the processing basis.
/// </summary>
public class ProcessingBasisDto : ProcessingBasisBase
{
    /// <summary>
    /// Processing basis id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Is newest version of processing basis group
    /// </summary>
    public bool IsNewestVersion { get; set; }

    /// <summary>
    /// When was the last modification?
    /// </summary>
    public DateTimeOffset? LastModified { get; set; }

    /// <summary>
    /// Who did the last modification?
    /// </summary>
    public int? LastModifiedById { get; set; }
}
