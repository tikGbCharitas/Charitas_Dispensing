using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetMaintenanceDt
{
    public string TransactionNo { get; set; } = null!;

    public bool IsMasterItem { get; set; }

    public string ItemID { get; set; } = null!;

    public decimal Quantity { get; set; }

    public string ItemUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public string BaseItemUnit { get; set; } = null!;

    public decimal BaseQuantity { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int MaintenanceItemId { get; set; }
}
