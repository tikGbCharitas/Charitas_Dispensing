using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlMasterReport
{
    public int RlMasterReportID { get; set; }

    public string RlMasterReportNo { get; set; } = null!;

    public string RlMasterReportName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? Notes { get; set; }
}
