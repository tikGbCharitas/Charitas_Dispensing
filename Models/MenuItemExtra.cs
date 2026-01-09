using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MenuItemExtra
{
    public string SeqNo { get; set; } = null!;

    public string MenuID { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public string SRMealSet { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
