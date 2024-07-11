using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Salary;

public class CommissionSharingDto
{
    /// <summary>
    /// id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Employee Id
    /// </summary>
    public int EmployeeId { get; set; }
    /// <summary>
    /// Case ID
    /// </summary>
    public int CaseBaseId { get; set; }
    /// <summary>
    /// Extra payemnt for this employee
    /// </summary>
    public decimal? ExtraPayment { get; set; }

    /// <summary>
    /// Shared percentage
    /// </summary>
    public decimal? Percentage { get; set; }

    /// <summary>
    /// Type of the sharing
    /// </summary>
    public CommissionSharingType Type { get; set; }
}
