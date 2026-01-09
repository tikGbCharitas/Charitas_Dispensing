using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MultiBatchBalanceBin
{
    public int MultiBatchBalanceBinID { get; set; }

    public string LocationID { get; set; } = null!;

    public int BinID { get; set; }

    public string ItemID { get; set; } = null!;

    public string NIE_BPOM { get; set; } = null!;

    public string BatchID { get; set; } = null!;

    public DateTime ExpiredDate { get; set; }

    public decimal Quantity { get; set; }

    public string LastUpdateUser { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string? Barcode { get; set; }

    public virtual MultiBatchItemBin Bin { get; set; } = null!;

    public virtual MultiBatchBalance MultiBatchBalance { get; set; } = null!;

    public virtual ICollection<MultiBatchBalanceBinLog> MultiBatchBalanceBinLogs { get; set; } = new List<MultiBatchBalanceBinLog>();

    public virtual ICollection<MultiBatchInventoryBin> MultiBatchInventoryBins { get; set; } = new List<MultiBatchInventoryBin>();
}
