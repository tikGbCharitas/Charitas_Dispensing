using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetUtilization
{
    public string AssetID { get; set; } = null!;

    public string PeriodNo { get; set; } = null!;

    public short UsageCounter { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
