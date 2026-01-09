using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitAlias
{
    public string ServiceUnitID { get; set; } = null!;

    public string ServiceUnitAliasID { get; set; } = null!;

    public string? ServiceUnitAliasName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
