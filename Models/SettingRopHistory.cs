using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SettingRopHistory
{
    public Guid RopHistoryID { get; set; }

    public DateTime RopHistoryDateTime { get; set; }

    public string LocationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal FromMinimum { get; set; }

    public decimal ToMinimum { get; set; }

    public decimal FromMaximum { get; set; }

    public decimal ToMaximum { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
