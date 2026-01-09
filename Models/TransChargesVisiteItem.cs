using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesVisiteItem
{
    public string TransactionNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public int VisiteQty { get; set; }

    public int RealizationQty { get; set; }

    public bool? IsClosed { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedDateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
