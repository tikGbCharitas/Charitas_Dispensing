using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientVitalSignMonitoringItem
{
    public string RegistrationNo { get; set; } = null!;

    public string OrderNo { get; set; } = null!;

    public string VitalSignID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual PatientVitalSignMonitoring PatientVitalSignMonitoring { get; set; } = null!;
}
