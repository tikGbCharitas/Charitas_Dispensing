using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientVitalSignMonitoring
{
    public string RegistrationNo { get; set; } = null!;

    public string OrderNo { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public string StartingTime { get; set; } = null!;

    public DateTime EndingDate { get; set; }

    public string EndingTime { get; set; } = null!;

    public string Interval { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual ICollection<PatientVitalSignMonitoringItem> PatientVitalSignMonitoringItems { get; set; } = new List<PatientVitalSignMonitoringItem>();
}
