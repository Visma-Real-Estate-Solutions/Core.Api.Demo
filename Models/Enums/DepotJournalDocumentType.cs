using System.ComponentModel;

namespace CoreDemo.Models.Enums;

/// <summary>
/// Depot journal document type
/// </summary>
public enum DepotJournalDocumentType
{
    /// <summary>
    /// None
    /// </summary>
    [Description("Ingen")] None,

    /// <summary>
    /// Security interest
    /// </summary>
    [Description("Sikringsobligasjon")] SecurityInterest,

    /// <summary>
    /// Deed or Legal document
    /// </summary>
    [Description("Skjøte/Hjemmelsdokument")]
    DeedOrLegalDocument,

    /// <summary>
    /// Legal statement
    /// </summary>
    [Description("Hjemmelserklæring ved arv/skift/utskifte")]
    LegalStatement,

    /// <summary>
    /// Bond or Mortage Deed
    /// </summary>
    [Description("Obligasjon/Pantedokument")]
    BondOrMortageDeed,

    /// <summary>
    /// Bank guarantee
    /// </summary>
    [Description("Bankgaranti")] BankGuarantee,

    /// <summary>
    /// Transport statement
    /// </summary>
    [Description("Transporterklæring")] TransportStatement,

    /// <summary>
    /// Support Agreement
    /// </summary>
    [Description("Inneståelseserklæring")] SupportAgreement,

    /// <summary>
    /// Lease contract
    /// </summary>
    [Description("Festekontrakt")] LeaseContract,

    /// <summary>
    /// Sales authorization
    /// </summary>
    [Description("Fullmakt salg")] SalesAuthorization,

    /// <summary>
    /// Purchase authorization
    /// </summary>
    [Description("Fullmakt kjøp")] PurchaseAuthorization,

    /// <summary>
    /// Declaration of concession freedom
    /// </summary>
    [Description("Egenerklæring om konsesjonsfrihet")]
    DeclarationOfConcessionFreedom,

    /// <summary>
    /// General authorization
    /// </summary>
    [Description("Generalfullmakt")] GeneralAuthorization,

    /// <summary>
    /// Legal authorization
    /// </summary>
    [Description("Fullmakt fra hjemmelshaver")]
    LegalAuthorization,

    /// <summary>
    /// Pawn Shared Debt HousingAssociation,
    /// </summary>
    [Description("Pantedokument Fellesgjeld BL")]
    PawnSharedDebtHousingAssociation,

    /// <summary>
    /// Pawn Deposit HousingAssociation
    /// </summary>
    [Description("Pantedokument Innskudd BL")]
    PawnDepositHousingAssociation,

    /// <summary>
    /// Garanty Simple
    /// </summary>
    [Description("§12 Garanti - Enkel")] GarantySimple,

    /// <summary>
    /// Garanty Collected
    /// </summary>
    [Description("§12 Garanti - Samlet")] GarantyCollected,

    /// <summary>
    /// Garanty Prepayment
    /// </summary>
    [Description("§47 Garanti - Forskudd")]
    GarantyPrepayment,

    /// <summary>
    /// Non disposal (Urådighet)
    /// </summary>
    [Description("Urådighet")] NonDisposal,

    /// <summary>
    /// Share register notfication (Notifikasjon aksjebok)
    /// </summary>
    [Description("Notifikasjon aksjebok")] ShareRegisterNotification,

    [Description("Skjøte pkt. 7 – kjøpers erklæring")]
    DeedSectionSevenBuyerStatement,

    [Description("Sikringsobligasjon – elektronisk")]
    DigitalSecurityInterest,

    [Description("Skjøte/Hjemmelsdokument – elektronisk")]
    DigitalDeedOrLegalDocument,

    [Description("Besittelseserklæring (aksjeleilighet)")]
    PossessionStatementStockApartment,

    [Description("§47 Garanti – Forskudd – Enkel")]
    GuaranteeAdvanceSimple,

    [Description("§47 Garanti – Forskudd - Samlet")]
    GuaranteeAdvanceCollected,

    /// <summary>
    /// Bond or Mortgage Deed - electronic
    /// </summary>
    [Description("Obligasjon/Pantedokument - elektronisk")]
    BondOrMortgageDeedElectronic
}
