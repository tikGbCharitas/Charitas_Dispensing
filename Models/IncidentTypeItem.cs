using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class IncidentTypeItem
{
    public string SRIncidentType { get; set; } = null!;

    public string ComponentID { get; set; } = null!;

    public string SubComponentID { get; set; } = null!;

    public string SubComponentName { get; set; } = null!;

    public bool IsAllowEdit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
