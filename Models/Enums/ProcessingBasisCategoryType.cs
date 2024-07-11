namespace CoreDemo.Models.Enums;

/// <summary>
/// ProcessingBasis Category Type
/// </summary>
public enum ProcessingBasisCategoryType
{
    /// <summary>
    /// Frittstående (urelatert)
    /// </summary>
    Standalone,

    /// <summary>
    /// Gjelder en spesifikk eiendom
    /// </summary>
    SpecificCase,

    /// <summary>
    /// Gjelder lignende eiendommer
    /// </summary>
    SimilarCases,

    /// <summary>
    /// Er relatert til et lead
    /// </summary>
    Lead,

    /// <summary>
    /// Er relatert til et banktips
    /// </summary>
    BankLead
}
