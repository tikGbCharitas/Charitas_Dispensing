using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppControlEntryMatrix
{
    public string HealthcareInitialAppsVersion { get; set; } = null!;

    public string EntryType { get; set; } = null!;

    public string ControlID { get; set; } = null!;

    public int IndexNo { get; set; }

    public bool IsVisible { get; set; }

    public string? ReferenceValue { get; set; }
}
