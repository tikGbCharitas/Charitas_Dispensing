using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Diagnose_Old
{
    public string DiagnoseID { get; set; } = null!;

    public string? DtdNo { get; set; }

    public string DiagnoseName { get; set; } = null!;

    public bool IsChronicDisease { get; set; }

    public bool IsDisease { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual Dtd? DtdNoNavigation { get; set; }
}
