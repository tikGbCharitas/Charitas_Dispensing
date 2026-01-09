using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitVitalSign
{
    public string ServiceUnitID { get; set; } = null!;

    public string VitalSignID { get; set; } = null!;

    public int? RowIndex { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
