using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Case;

public class PropertyConditionsCostsDto
{
    public int? BrokerCompanySettlementStatementDefinitionId { get; set; }
    public int? ProjectSettlementStatementDefinitionId { get; set; }
    public int? OfficeSettlementStatementDefinitionId { get; set; }
    public bool AddedFromSale { get; set; }
    public bool AddedFromCase { get; set; }
    public bool DisplayWarning { get; set; }
    public bool Editable { get; set; }
    public bool IsAccounted { get; set; }
    public bool Selected { get; set; }
    public int? EntryDraftId { get; set; }
    public int? EntryId { get; set; }
    public int Id { get; set; }
    public string? AccountNumber { get; set; }
    public int Amount { get; set; }
    public int? BankTransferTypeId { get; set; }
    public int? BusinessManagerId { get; set; }
    public string? Comment { get; set; }
    public int? ClientAccountId { get; set; }
    public int? CustomerId { get; set; }
    public bool Deleted { get; set; }
    public int? EntryDefinitionId { get; set; }
    public string? EntryDefinitionOverruled { get; set; }
    public DateTime? FromDate { get; set; }
    public bool? IsCommissionDiscount { get; set; }
    public bool IsEditable { get; set; }
    public bool? IsHidden { get; set; }
    public bool IsStandard { get; set; }
    public bool? IsOptional { get; set; }
    public string? KidNumber { get; set; }
    public StandardCostStatusType? StandardCostStatusType { get; set; }
    public StandardCostStatusType? StatusType { get; set; }
    public StandardCostAccountingType? AccountingType { get; set; }
    public StandardCostAccountingType? StandardCostPostStatusType { get; set; }
    public SettlementStatementGroup? SettlementStatementGroup { get; set; }
    public int? VAT { get; set; }
}
