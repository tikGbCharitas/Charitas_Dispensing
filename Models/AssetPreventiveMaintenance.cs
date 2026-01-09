using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetPreventiveMaintenance
{
    public string PMNo { get; set; } = null!;

    public DateTime PMDate { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string AssetID { get; set; } = null!;

    public string SRWorkTrade { get; set; } = null!;

    public DateTime TargetDate { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
