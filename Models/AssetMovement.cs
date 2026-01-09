using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetMovement
{
    public string AssetMovementNo { get; set; } = null!;

    public DateTime MovementDate { get; set; }

    public string AssetID { get; set; } = null!;

    public string FromDepartmentID { get; set; } = null!;

    public string FromServiceUnitID { get; set; } = null!;

    public string FromAssetLocationID { get; set; } = null!;

    public string ToDepartmentID { get; set; } = null!;

    public string ToServiceUnitID { get; set; } = null!;

    public string ToAssetLocationID { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool IsPosted { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
