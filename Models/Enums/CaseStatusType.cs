namespace CoreDemo.Models.Enums;

/// <summary>
/// Case status type
/// </summary>
public enum CaseStatusType
{
    /// <summary>
    /// Initial status (created)
    /// </summary>
    Initial,

    /// <summary>
    /// General status
    /// </summary>
    General,

    /// <summary>
    /// Case draft
    /// </summary>
    Draft,

    /// <summary>
    /// Active case
    /// </summary>
    Active,

    /// <summary>
    /// Ready to publish
    /// </summary>
    Ready,

    /// <summary>
    /// Case has been sold
    /// </summary>
    Sold,

    /// <summary>
    /// Case has been archived
    /// </summary>
    Archived,

    /// <summary>
    /// Case is reserved
    /// </summary>
    Reserved,

    /// <summary>
    /// Bidding has started
    /// </summary>
    BiddingStarted,

    /// <summary>
    /// Case is canceled due to agreement cancelation
    /// </summary>
    Canceled,

    /// <summary>
    /// Case is being followed up
    /// </summary>
    Followup,

    /// <summary>
    /// When the Case is sold, but with undefined conditions
    /// </summary>
    SoldWithConditions,

    /// <summary>
    /// When the Case is lost
    /// </summary>
    Lost,

    /// <summary>
    /// When case is ready for document delivery (Mappelevering)
    /// </summary>
    DocumentDelivery
}
