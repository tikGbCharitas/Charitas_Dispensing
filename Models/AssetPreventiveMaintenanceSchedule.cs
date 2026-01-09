using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetPreventiveMaintenanceSchedule
{
    public string AssetID { get; set; } = null!;

    public DateTime ScheduleDate { get; set; }

    public string? PeriodYear { get; set; }

    public DateTime PeriodDate { get; set; }

    public bool IsProcessed { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
