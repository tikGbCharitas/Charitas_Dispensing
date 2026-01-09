using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class DataRptMaster
{
    public string SRDataRpt { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string? SeqNo { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
