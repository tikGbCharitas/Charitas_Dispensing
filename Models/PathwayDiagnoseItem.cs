using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PathwayDiagnoseItem
{
    public string PathwayID { get; set; } = null!;

    public string DiagnoseID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
