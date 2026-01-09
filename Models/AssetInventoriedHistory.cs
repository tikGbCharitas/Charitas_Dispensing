using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetInventoriedHistory
{
    public string AssetID { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public DateTime InventoriedDate { get; set; }

    public string InventoriedBy { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
