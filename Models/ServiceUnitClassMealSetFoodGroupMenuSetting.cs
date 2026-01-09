using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitClassMealSetFoodGroupMenuSetting
{
    public string ServiceUnitID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string SRMealSet { get; set; } = null!;

    public string SRFoodGroup1 { get; set; } = null!;

    public bool? IsOptional { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
