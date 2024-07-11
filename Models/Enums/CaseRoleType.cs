namespace CoreDemo.Models.Enums;

public enum CaseRoleType
{
    Broker,

    AssistantBroker,

    SettlementResponsible,

    HousingAssociation,

    BusinessManager,

    BusinessResponsible,

    /// <summary>
    /// Bidder (has placed a bid)
    /// </summary>
    Bidder,

    /// <summary>
    /// Buyer (has bought the property)
    /// </summary>
    Buyer,

    /// <summary>
    /// Legal owner
    /// </summary>
    Owner,

    [Obsolete("The API-method 'Cases/{id}/Office' can be used to get the Office assigned to a Case.")]
    Office,

    RegistrationResponsible,

    Seller,

    /// <summary>
    /// Stakeholder (has shown interest in property)
    /// </summary>
    Stakeholder,

    /// <summary>
    /// Property stylist
    /// </summary>
    Stylist,

    Photographer,

    /// <summary>
    /// Unknown
    /// </summary>
    None,

    AssociateBroker,

    ContactPerson,

    /// <summary>
    /// Authorized assignee
    /// </summary>
    Assignee,

    /// <summary>
    /// Property developer
    /// </summary>
    [Obsolete("Use seller instead")]
    Developer,

    StockCompany,

    /// <summary>
    /// Spouse (is married to)
    /// </summary>
    Spouse,

    ResponsibleBroker,

    /// <summary>
    /// Plaintiff (suer)
    /// </summary>
    Plaintiff,

    /// <summary>
    /// Defendant (is being sued)
    /// </summary>
    Sued,

    RealEstateRepresentative,

    AssociatedStakeholder,

    /// <summary>
    /// Joint owner (Sameier)
    /// </summary>
    JointOwner,

    /// <summary>
    /// Community organisation (Velforrening)
    /// </summary>
    CommunityOrganisation,

    /// <summary>
    /// Surety: garantist
    /// </summary>
    Surety,

    /// <summary>
    /// Construction loan bank : Byggelånsbank
    /// </summary>
    ConstructionLoanBank,

    /// <summary>
    /// Opprinnelig kjøper
    /// </summary>
    OriginalBuyer,

    /// <summary>
    /// Kjøpers fullmektig
    /// </summary>
    BuyerAssignee,

    /// <summary>
    /// Assistent eller administrasjon
    /// </summary>
    Assistant,

    /// <summary>
    /// Selskap som selges
    /// </summary>
    CompanyToSell,
    JointOwnership,
    Chairman,
    CommonInsurance,
    Landowner,
    FireDepartment,
    RenovationCompany,
    ElectricalCompany,
    WaterCompany,
    Appraiser,
    AppraisalCompany,
    SellerBank,
    BuyerBank,
    CountyGovernor,
    CommunityOrganisationCompany,
    Manager,
    Counsel,

    /// <summary>
    /// Oppgjørsfirma
    /// </summary>
    SettlementCompany
}
