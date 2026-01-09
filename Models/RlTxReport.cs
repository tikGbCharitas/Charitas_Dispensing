using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlTxReport
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportID { get; set; }

    public string PeriodYear { get; set; } = null!;

    public string PeriodMonthStart { get; set; } = null!;

    public string PeriodMonthEnd { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
