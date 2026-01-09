using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DataRptItem
{
    public string SRDataRpt { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public short? Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
