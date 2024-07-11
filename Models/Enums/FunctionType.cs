namespace CoreDemo.Models.Enums;

/// <summary>
/// Enum used to describe roles a contact can have
/// See CaseRole for roles a contact can have on a case
/// </summary>
public enum FunctionType
{
    AppraisalCompany,   // Takstfirma
    Appraiser,          // Takstmann
    FireDepartment,
    RenovationCompany,
    ElectricalCompany,
    WaterCompany,
    BusinessManager,        // Forretningsfører
    CommunityOrganisation,  // Velforening
    Stylist,
    Photographer,
    Municipality,       // Kommune
    InsuranceCompany,   // Forsikringsselskap
    DistrictCounts,     // Fylkeskommune
    CustomerAdvisor,    // Kunderådgiver
    Auditor,            // Revisor

    HousingAssociation, // Borettslag
    Bank,
    BrokerCompany,      // Meglerforetak
    Employee,
    Team,
    Group,
    Chain,
    OfficeLocation,     // Kontorsted
    Office,             // Avdeling

    StockCompany,   // Aksjeselskap
    Landowner,      // Grunneier
    School,
    Treasurer,      // Kemner
    Supplier,       // Leverandør
    TaxOffice,      // Ligningskontor
    SurveyCompany,  // Oppmålingskontoret
    Consignor,      // Rekvirent
    Licensee,       // Rettighetshaver
    Court,          // Rettsinstans
    Magistrate,     // Sorenskriver
    DistrictCourt,  // Tingrett
    JointOwnership, // Sameie

    Unknown,        // Ukjent

    Chairman,       // Styreleder
    BuyerBank,      // Kjøpers kreditor
    SellerBank,     // Selgers kreditor
    Surety,         // Garantist
    CountyGovernor,  // Fylkesmann,
    SignatoryCompanyCertificate, // Signaturrett ihht firmattest
    SignatoryAuthorization, // Signaturrett ihht fullmakt
    ChiefExecutiveOfficer, // Daglig leder
    PrimaryContact, // Hovedkontakt
    BoardMember, // Styremedlem
    CompanyOther, // Annet (Company),
    PersonOther, // Annet (Person),
    AppropriationRepresentativeSeller, // Overtagelsesrepresentant Selger
    BeneficialOwner, // Reell rettighetshaver
    OtherRightsHolder // Annen rettighetshaver
}
