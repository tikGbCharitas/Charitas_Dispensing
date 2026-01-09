using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetMaintenanceOrder
{
    public string JobOrderNo { get; set; } = null!;

    public DateTime OrderedDate { get; set; }

    public string FromServiceUnitID { get; set; } = null!;

    public string FromLocationID { get; set; } = null!;

    public string ToServiceUnitID { get; set; } = null!;

    public string AssetID { get; set; } = null!;

    public string RequestBy { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public string Notes { get; set; } = null!;

    public bool IsPosted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
