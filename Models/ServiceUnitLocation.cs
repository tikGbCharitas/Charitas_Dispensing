using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitLocation
{
    public string ServiceUnitID { get; set; } = null!;

    public string LocationID { get; set; } = null!;

    public bool? IsLocationMain { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
