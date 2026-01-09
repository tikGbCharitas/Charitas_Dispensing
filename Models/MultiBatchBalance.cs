using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MultiBatchBalance
{
    public string LocationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal? Balance { get; set; }

    public string NIE_BPOM { get; set; } = null!;

    public string BatchID { get; set; } = null!;

    public DateTime ExpiredDate { get; set; }

    public DateTime? LastUpdateByTime { get; set; }

    public string? LastUpdateByid { get; set; }

    public string? LastTransactionNo { get; set; }

    public bool isOpen { get; set; }

    public string? Barcode { get; set; }

    public virtual ICollection<MultiBatchBalanceBin> MultiBatchBalanceBins { get; set; } = new List<MultiBatchBalanceBin>();
}
