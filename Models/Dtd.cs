using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Dtd
{
    public string DtdNo { get; set; } = null!;

    public string DtdName { get; set; } = null!;

    public string DtdLabel { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SRChronicDisease { get; set; }

    public virtual ICollection<Diagnose_Old> Diagnose_Olds { get; set; } = new List<Diagnose_Old>();
}
