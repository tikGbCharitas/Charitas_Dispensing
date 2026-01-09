using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PathologyAnatomyImpressionGroupItem
{
    public string GroupID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
