using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppUserServiceUnit_ron
{
    public string UserID { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public bool? IsDiscontinue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
