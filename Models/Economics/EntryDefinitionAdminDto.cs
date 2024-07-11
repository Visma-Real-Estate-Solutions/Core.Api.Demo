using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Economics;

/// <summary>
/// Contains additional information needed for editing.
/// </summary>
public class EntryDefinitionAdminDto : EntryDefinitionDto
{
    /// <summary>
    /// The entry definition type.
    /// </summary>
    public EntryDefinitionType EntryDefinitionType { get; set; }

    /// <summary>
    /// If credit transaction should have VAT.
    /// </summary>
    public bool CreditVat { get; set; }

    /// <summary>
    /// If debit transaction should have VAT.
    /// </summary>
    public bool DebitVat { get; set; }

    /// <summary>
    /// Which CaseCategories this should be available for.
    /// </summary>
    public IEnumerable<CaseCategoryType>? AvailableForCaseCategories { get; set; }

    /// <summary>
    /// Which AssignmentTypes this should be available for.
    /// </summary>
    public IEnumerable<AssignmentType>? AvailableForAssignmentTypes { get; set; }

    /// <summary>
    /// If bank transfer type exist for this entry definition.
    /// </summary>
    public bool CreateBankTransferType { get; set; }

    /// <summary>
    /// The internal name for the banktransfertype if it exist.
    /// </summary>
    public string? BankTransferTypeInternalName { get; set; }

    /// <summary>
    /// If settlement statement entry definition exist for this entry definition.
    /// </summary>
    public bool CreateSettlementStatementEntryDefinition { get; set; }

    /// <summary>
    /// Will this entry definition enable KAR auto lookup in relevant places. i.e bank transfer popup
    /// </summary>
    public bool IsKarAutoLookup { get; set; }

    /// <summary>
    /// Will KAR auto lookup only happen on AML enhanced cases
    /// </summary>
    public bool IsKarAutoLookupEnhancedAml { get; set; }

    /// <summary>
    /// For transactions over this amount the KAR lookup will happen
    /// </summary>
    public decimal? KarAutoLookupAboveAmountLimitAmount { get; set; }

    /// <summary>
    /// Is valid KAR required to created/edit bank transfers for this entry definition
    /// </summary>
    public bool IsValidKarRequiredForBankTransfers { get; set; }

    /// <summary>
    /// Is valid KAR only required on AML enhanced cases
    /// </summary>
    public bool IsValidKarRequiredForBankTransfersEnhancedAml { get; set; }

    /// <summary>
    /// KAR lookup is required over this amount
    /// </summary>
    public decimal? KarBankTransfersAboveAmountLimitAmount { get; set; }


    /// <summary>
    /// If the entry definition is deleted.
    /// </summary>
    public bool IsDeleted { get; set; }
}
