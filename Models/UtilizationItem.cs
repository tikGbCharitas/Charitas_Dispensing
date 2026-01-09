using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class UtilizationItem
{
    public string UtilizationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? Notes { get; set; }
}
