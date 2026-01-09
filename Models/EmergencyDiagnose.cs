using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmergencyDiagnose
{
    public string EmrDiagnoseID { get; set; } = null!;

    public string EmrDiagnoseName { get; set; } = null!;

    public string? SREmrDiagnoseGroupID { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
