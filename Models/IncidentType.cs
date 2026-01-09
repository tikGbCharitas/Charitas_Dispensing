using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class IncidentType
{
    public string SRIncidentType { get; set; } = null!;

    public string ComponentID { get; set; } = null!;

    public string ComponentName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
