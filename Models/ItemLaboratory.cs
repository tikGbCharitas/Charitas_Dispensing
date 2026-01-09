using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemLaboratory
{
    public string ItemID { get; set; } = null!;

    public string ReportRLID { get; set; } = null!;

    public bool IsAdminCalculation { get; set; }

    public bool IsAllowVariable { get; set; }

    public bool IsAllowCito { get; set; }

    public bool IsAllowDiscount { get; set; }

    public bool IsAssetUtilization { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsDisplayInOrderList { get; set; }

    public int? RlMasterReportItemID { get; set; }

    public string? SRExaminationClass { get; set; }

    public string? SRLaboratoryUnit { get; set; }

    public int? LevelNo { get; set; }

    public int? DisplaySequence { get; set; }

    public virtual Item Item { get; set; } = null!;
}
