using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Activities;

/// <summary>
/// Represents an activity.
/// </summary>
public class ActivityModelDto
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The id of the property the activity is connected to.
    /// </summary>
    public int? CaseId { get; set; }

    /// <summary>
    /// The activity subject.
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// An activity description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// When the activity was created.
    /// </summary>
    public DateTimeOffset CreatedOn { get; set; }

    /// <summary>
    /// When the activity was last modified.
    /// </summary>
    public DateTimeOffset? LastModified { get; set; }

    /// <summary>
    /// The start time of the activity.
    /// </summary>
    public DateTimeOffset? DateTime { get; set; }

    /// <summary>
    /// The end time of an activity.
    /// </summary>
    public DateTimeOffset? EndDateTime { get; set; }

    /// <summary>
    /// The activity deadline date time.
    /// </summary>
    public virtual DateTimeOffset? Deadline { get; set; }

    /// <summary>
    /// True if the activity is completed.
    /// </summary>
    public bool IsCompleted { get; set; }

    /// <summary>
    /// The contact id of the activity organizer.
    /// </summary>
    public int OrganizerId { get; set; }

    /// <summary>
    /// The activity type.
    /// </summary>
    public ActivityType ActivityType { get; set; }

    /// <summary>
    /// True if the activity is private.
    /// </summary>
    public bool IsPrivate { get; set; }

    /// <summary>
    /// True if is all day.
    /// </summary>
    public bool IsAllDay { get; set; }

    /// <summary>
    /// Used to determine if a recurring activity has an end date.
    /// </summary>
    public bool NoEndDate { get; set; }

    /// <summary>
    /// Last modified by id.
    /// </summary>
    public virtual int? LastModifiedById { get; set; }

    /// <summary>
    /// Created by id.
    /// </summary>
    public int? CreatedById { get; set; }

    /// <summary>
    /// True if activity is a draft.
    /// </summary>
    public bool IsDraft { get; set; }

    /// <summary>
    /// Determines if this activity is recurring.
    /// </summary>
    public bool IsRecurring { get; set; }

    /// <summary>
    /// The activity type.
    /// </summary>
    public ActivityRecurrenceFlowType? ActivityRecurrenceType { get; set; }

    /// <summary>
    /// The number of recurrences.
    /// </summary>
    public int? NumberOfOccurrences { get; set; }

    /// <summary>
    /// The date this recurrence pattern ends.
    /// </summary>
    public DateTimeOffset? RecurrenceEndDate { get; set; }

    /// <summary>
    /// The id of the series master.
    /// </summary>
    public int? SeriesMasterActivityId { get; set; }
}
