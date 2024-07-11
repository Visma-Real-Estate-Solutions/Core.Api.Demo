namespace CoreDemo.Models.Contacts;

public class OfficeDto : ContactDto
{
    public int OfficeNumber { get; set; }
    public string? Description { get; set; }
    public string? OrganisationNumber { get; set; }
}
