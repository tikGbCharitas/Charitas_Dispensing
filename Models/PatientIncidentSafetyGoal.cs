using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientIncidentSafetyGoal
{
    public string PatientIncidentNo { get; set; } = null!;

    public string SRSafetyGoals { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
