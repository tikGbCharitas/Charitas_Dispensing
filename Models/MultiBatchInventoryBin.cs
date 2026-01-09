using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MultiBatchInventoryBin
{
    public string TransactionNo { get; set; } = null!;

    public int MultiBatchBalanceBinID { get; set; }

    public decimal? FromQty { get; set; }

    public decimal? ToQty { get; set; }

    public DateTime? LastUpdatebyTime { get; set; }

    public string? LastUpdatebyID { get; set; }

    public virtual MultiBatchBalanceBin MultiBatchBalanceBin { get; set; } = null!;
}
