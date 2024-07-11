namespace CoreDemo.Models.Activities;

/// <summary>
/// Activity participant model.
/// </summary>
public class ActivityParticipantModelDto
{
    /// <summary>
    /// Contact Id
    /// </summary>
    public int ContactId { get; set; }

    /// <summary>
    /// Activity id
    /// </summary>
    public int ActivityId { get; set; }

    /// <summary>
    /// Number of people joining together with this person.
    /// </summary>
    public int Followers { get; set; }

    /// <summary>
    /// The date of registration for the activity.
    /// </summary>
    public DateTimeOffset? RegistrationDate { get; set; }
}
