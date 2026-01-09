using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MultiBatchItemBin
{
    public int BinID { get; set; }

    public string BinName { get; set; } = null!;

    public string LocationID { get; set; } = null!;

    public string LastUpdateUser { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<MultiBatchBalanceBin> MultiBatchBalanceBins { get; set; } = new List<MultiBatchBalanceBin>();

    public virtual ICollection<MultiBatch> MultiBatches { get; set; } = new List<MultiBatch>();
}
