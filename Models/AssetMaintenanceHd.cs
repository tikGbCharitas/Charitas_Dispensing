using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetMaintenanceHd
{
    public string TransactionNo { get; set; } = null!;

    public DateTime MaintenanceDate { get; set; }

    public string JobOrderNo { get; set; } = null!;

    public string AssetID { get; set; } = null!;

    public string SRMaintenanceType { get; set; } = null!;

    public string MaintenanceBy { get; set; } = null!;

    public decimal Condition { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime NextMaintenanceDate { get; set; }

    public bool IsPosted { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
