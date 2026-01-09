using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport3_6
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemID { get; set; }

    public int? Total { get; set; }

    public int? Khusus { get; set; }

    public int? Besar { get; set; }

    public int? Sedang { get; set; }

    public int? Kecil { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
