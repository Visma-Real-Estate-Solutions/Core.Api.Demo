using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Case;

public class LandLotLeaseInformationDto
{
    public int Id { get; set; }
    public DateTime? ContractStartDate { get; set; }
    public decimal? LeaseFee { get; set; }
    public DateTime? LeaseFeeChangedDate { get; set; }
    public string? Comment { get; set; }
    public PropertyLevelType? PropertyLevel { get; set; }
    public DateTime? ContractEndDate { get; set; }
    public bool IsContractAnnulable { get; set; }
    public bool IsContractTransferApproved { get; set; }
    public decimal? ContractTransferFee { get; set; }
    /// <summary>
    /// Owner of the landlot (bortfester)
    /// </summary>
    public List<int> LessorIds { get; set; } = new List<int>();
}
