using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetPreventiveMaintenanceSchedulePeriod
{
    public string AssetID { get; set; } = null!;

    public string PeriodYear { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
