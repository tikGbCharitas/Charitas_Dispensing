using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetLocation
{
    public string AssetLocationID { get; set; } = null!;

    public string AssetLocationName { get; set; } = null!;

    public string DepartmentID { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string Approver { get; set; } = null!;

    public string PersonInCharge { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
