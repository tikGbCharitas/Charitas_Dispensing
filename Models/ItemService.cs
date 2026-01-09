using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemService
{
    public string ItemID { get; set; } = null!;

    public string ReportRLID { get; set; } = null!;

    public string SRItemUnit { get; set; } = null!;

    public bool? IsPrimaryService { get; set; }

    public bool IsAdminCalculation { get; set; }

    public bool IsAllowVariable { get; set; }

    public bool IsAllowCito { get; set; }

    public bool IsAllowDiscount { get; set; }

    public bool IsPrintWithDoctorName { get; set; }

    public bool IsAssetUtilization { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? PremiAmount { get; set; }

    public decimal? Premi2Amount { get; set; }

    public decimal? ProductionServicesPercentage { get; set; }

    public decimal? TogethernessPercentage { get; set; }

    public decimal? ProductionServicesPercentage2 { get; set; }

    public string? ItemRelatedID { get; set; }

    public decimal? QtyDivider { get; set; }

    public int? RlMasterReportItemID { get; set; }

    public string? SRItemGroupMapping { get; set; }

    public string? SRTypeDoctor { get; set; }

    public string? ListServiceUnitID { get; set; }

    public string? SRCompetencyDoctor { get; set; }

    public virtual Item Item { get; set; } = null!;
}
