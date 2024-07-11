namespace CoreDemo.Models.Enums;

/// <summary>
/// Processing basis system types
/// </summary>
public enum ProcessingBasisSystemType
{
    /// <summary>
    /// Manually set processing basis (i.e not system triggered)
    /// </summary>
    Manual,

    /// <summary>
    /// Automatically set by system when a seller role is assigned
    /// </summary>
    IsSeller,

    /// <summary>
    /// Automatically set by system when a buyer role is assigned
    /// </summary>
    IsBuyer,

    /// <summary>
    /// Automatically set by system when a stakeholder role is assigned
    /// </summary>
    IsStakeholder,

    /// <summary>
    /// Automatically set by system when a bidder role is assigned
    /// </summary>
    IsBidder,

    /// <summary>
    /// Automatically set by system when a support case role is assigned
    /// </summary>
    /// <remarks>See EntityBaseHelper.cs for list of support roles.</remarks>
    IsSupportRole,

    /// <summary>
    /// Automatically set by system when an other (minor) role is assigned
    /// </summary>
    /// <remarks>See EntityBaseHelper.cs for list of main and support roles.</remarks>
    IsOtherRole,

    /// <summary>
    /// A basic premisson for registration of users in customerweb
    /// </summary>
    CustomerRegistration,

    /// <summary>
    /// Used to make the user contactable in regards to newsletters and other updates regarding the property market
    /// </summary>
    NewsLetter,

    /// <summary>
    /// Checklist related processing basis (can be linked to checklist item)
    /// </summary>
    Checklist,

    /// <summary>
    /// Close contacts related processing basis
    /// </summary>
    CloseContacts
}
