namespace CoreDemo.Models.Contacts;

public class SettlementJournalDto
{
    public int Id { get; set; }

    public int OfficeId { get; set; }

    public string? OfficeName { get; set; }

    public string? SettlementReferralKey { get; set; } //Settlement key

    public DateTimeOffset? SentToSettlementTeamDate { get; set; } //Date sent to settlement team

    public DateTimeOffset? ReceivedBySettlementTeam { get; set; } //Date received  by settlement team

    public string? Address { get; set; } //Address of the settlement object

    public string? RegistryDescription { get; set; } //Registry gnr/bnr or housingAssociation info, and municipality info

    public string? SourceCompanyDescription { get; set; } // Source company for this settlement

    public string? SellerInfo { get; set; }  // Sellers name

    public string? BuyerInfo { get; set; } // buyers name

    public decimal Cost { get; set; }

    public string? SettlementResponsible { get; set; } // settlementResponsible name
}
