using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitClassMenuExtraSetting
{
    public string ServiceUnitID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string? MenuID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
