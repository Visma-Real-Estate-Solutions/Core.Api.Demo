namespace CoreDemo.Models.Enums;

/// <summary>
/// Where to display a processing basis
/// </summary>
public enum ProcessingBasisDisplayType
{
    /// <summary>
    /// Display consent for showing forms
    /// </summary>
    Showing,

    /// <summary>
    /// Display consent for prospectus download forms
    /// </summary>
    Prospectus,

    /// <summary>
    /// Display consent for manual registration
    /// </summary>
    Manual,

    /// <summary>
    /// Display consent for leads/contact register
    /// </summary>
    Lead,

    /// <summary>
    /// Display consent for bid registration forms
    /// </summary>
    Bidding,

    /// <summary>
    /// Display consent for close contacts.
    /// </summary>
    CloseContacts
}
