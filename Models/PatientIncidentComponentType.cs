using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientIncidentComponentType
{
    public string PatientIncidentNo { get; set; } = null!;

    public string SRIncidentType { get; set; } = null!;

    public string ComponentID { get; set; } = null!;

    public string SubComponentID { get; set; } = null!;

    public string SubComponentName { get; set; } = null!;

    public string? Modus { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
