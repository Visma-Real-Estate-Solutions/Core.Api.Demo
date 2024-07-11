namespace CoreDemo.Models.Enums;

/// <summary>
/// Charge base calculation area types.
/// Only used when calculating charge basis on project units.
/// </summary>
public enum ChargeBasisType
{
    /// <summary>
    /// Bruksareal.
    /// </summary>
    FloorSpace,

    /// <summary>
    /// Tomteareal
    /// </summary>
    LandLotArea,

    /// <summary>
    /// AskingPrice or SalePrice + debt (if exists)
    /// </summary>
    Price,

    /// <summary>
    /// Fritak
    /// </summary>
    NoCharge
}
