using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class sitb_icdmapping
{
    public string DiagnoseID { get; set; } = null!;

    public string? AnatomicalLocation { get; set; }

    public string? DiagnoseType { get; set; }
}
