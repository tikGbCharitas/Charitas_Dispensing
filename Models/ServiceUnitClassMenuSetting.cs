using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitClassMenuSetting
{
    public string ServiceUnitID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public bool? IsOptional { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
