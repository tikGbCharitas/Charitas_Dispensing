using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientIncidentUnderlyingCausesItemComponent
{
    public string PatientIncidentNo { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string FactorID { get; set; } = null!;

    public string FactorItemID { get; set; } = null!;

    public string ComponentID { get; set; } = null!;

    public string? ComponentName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
