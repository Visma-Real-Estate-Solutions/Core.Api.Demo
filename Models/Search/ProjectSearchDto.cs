namespace CoreDemo.Models.Search;

public class ProjectSearchDto : CaseSearchDto
{
    /// <summary>
    /// Id of the master project, only if the current project is a project step
    /// </summary>
    public int? MasterProjectId { get; set; }

    /// <summary>
    /// Name of the master project, only if the current project is a project step
    /// </summary>
    public string? MasterProjectName { get; set; }

    /// <summary>
    /// If this project is the master project
    /// </summary>
    public bool? IsMasterProject { get; set; }

    /// <summary>
    /// Name of the project step
    /// </summary>
    public string? ProjectStep { get; set; }

    /// <summary>
    /// Number of this project step
    /// </summary>
    public string? ProjectStepNumber { get; set; }

    /// <summary>
    /// Name of the projectStep or name of the project
    /// </summary>
    public string? ProjectName { get; set; }
}
