namespace CoreDemo.Models.Contacts;

public class OfficeInformationDto
{
    public int OfficeId { get; set; }
    public int BrokerCompanyId { get; set; }
    public string? HomePageUri { get; set; }
    public string? ClientAccountNumber { get; set; }
    public string? OperatingAccountNumber { get; set; }
    public int? OperatingAccountId { get; set; }
    public int WebId { get; set; }
    public string? FinnPartnerId { get; set; }
    public string? EiendomsnettCompanyId { get; set; }
    public string? ProtectorSettingOfficeId { get; set; }
    public string? HelpInsuranceOfficeId { get; set; }
    public bool SettlementPerformedBySettlementOffice { get; set; }
    public decimal? ExternalSettlementCost { get; set; }
    public int? SettlementCompanyId { get; set; }
    public int? NorwegianBrokerCompanyNumber { get; set; }
    public string? EtinglysningUsername { get; set; }
    public bool EtinglysningPasswordExists { get; set; }
    public bool AutoOrderEiendomsprofil { get; set; }
    public bool? IsMeglerKreditorOnSikring { get; set; }
}
