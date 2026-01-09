using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport3_11
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemID { get; set; }

    public int? Jumlah { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
