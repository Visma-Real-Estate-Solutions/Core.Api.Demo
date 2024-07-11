namespace CoreDemo.Models.Enums;

/// <summary>
/// Representing certain milestones for a case
/// </summary>
public enum CasePhaseType
{
    Registered,

    /// <summary>
    /// If the case is activated
    /// Do note that all activated cases have a casereferralkey and vice versa
    /// </summary>
    Activated,

    Published,
    Sold,

    /// <summary>
    /// Transferred from seller to buyer
    /// </summary>
    Transferred,

    Archived,
    Canceled
}
