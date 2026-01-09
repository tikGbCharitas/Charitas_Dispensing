using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BillingAdjustItemGroupSetting
{
    public string ItemGroupID { get; set; } = null!;

    public decimal DiscValue { get; set; }

    public int DiscSelection { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
