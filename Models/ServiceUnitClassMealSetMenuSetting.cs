using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitClassMealSetMenuSetting
{
    public string ServiceUnitID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string SRMealSet { get; set; } = null!;

    public bool? IsOptional { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
