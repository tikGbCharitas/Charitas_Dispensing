using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppUserCustomPivot
{
    public int CustomPivotID { get; set; }

    public string UserID { get; set; } = null!;

    public string ProgramID { get; set; } = null!;

    public string CustomPivotName { get; set; } = null!;
}
