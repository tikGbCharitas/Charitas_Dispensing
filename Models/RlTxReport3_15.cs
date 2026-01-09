using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport3_15
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemID { get; set; }

    public int? RiJpk { get; set; }

    public int? RiJld { get; set; }

    public int? Rj { get; set; }

    public int? RjLab { get; set; }

    public int? RjRad { get; set; }

    public int? RjLl { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
