using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MultiBatchBalanceBinLog
{
    public Guid MultiBatchBalanceBinLogID { get; set; }

    public int MultiBatchBalanceBinID { get; set; }

    public decimal QtyIn { get; set; }

    public decimal QtyOut { get; set; }

    public string? TransactionNo { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public virtual MultiBatchBalanceBin MultiBatchBalanceBin { get; set; } = null!;
}
