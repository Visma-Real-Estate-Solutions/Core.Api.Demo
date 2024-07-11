namespace CoreDemo.Models.General;

public class RecentlyModifiedCaseDto
{
    public DateTime ModifiedDate { get; set; }
    public DateTime? CaseActivatedDate { get; set; }
    public DateTime? CaseSoldDate { get; set; }
    public DateTime? BidChangedDate { get; set; }
    public DateTime? DescriptionChangedDate { get; set; }
    public DateTime? CaseEntityChangedDate { get; set; }
    public DateTime? ImageChangedDate { get; set; }
    public DateTime? AttachmentChangedDate { get; set; }
    public DateTime? TransactionChangedDate { get; set; }
    public DateTime? PublicationChangedDate { get; set; }
    public DateTime? ActivityChangedDate { get; set; }
    public int CaseId { get; set; }
}
