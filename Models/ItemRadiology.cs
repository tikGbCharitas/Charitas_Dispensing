using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemRadiology
{
    public string ItemID { get; set; } = null!;

    public string ReportRLID { get; set; } = null!;

    public bool IsAdminCalculation { get; set; }

    public bool IsAllowVariable { get; set; }

    public bool IsAllowCito { get; set; }

    public bool IsAllowDiscount { get; set; }

    public bool IsPrintWithDoctorName { get; set; }

    public bool IsAssetUtilization { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int? RlMasterReportItemID { get; set; }

    public virtual Item Item { get; set; } = null!;
}
