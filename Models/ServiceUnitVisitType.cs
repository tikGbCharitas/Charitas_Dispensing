using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitVisitType
{
    public string ServiceUnitID { get; set; } = null!;

    public string VisitTypeID { get; set; } = null!;

    public byte VisitDuration { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
