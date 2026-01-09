using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientIncidentKTD
{
    public string PatientIncidentNo { get; set; } = null!;

    public string SRIncidentKTD { get; set; } = null!;

    public string IncidentKTDName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
