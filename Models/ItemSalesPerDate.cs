using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemSalesPerDate
{
    public DateTime MovementDate { get; set; }

    public string SRStockGroup { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string LocationID { get; set; } = null!;

    public decimal QuantityOut { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
