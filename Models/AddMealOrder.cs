using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AddMealOrder
{
    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime EffectiveDate { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string? ClassID { get; set; }

    public string MenuID { get; set; } = null!;

    public string? MenuItemID { get; set; }

    public string? VersionID { get; set; }

    public string? SeqNo { get; set; }

    public string SRMealSet { get; set; } = null!;

    public short? Qty { get; set; }

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
