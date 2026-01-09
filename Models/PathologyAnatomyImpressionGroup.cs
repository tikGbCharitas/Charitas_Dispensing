using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PathologyAnatomyImpressionGroup
{
    public string GroupID { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
