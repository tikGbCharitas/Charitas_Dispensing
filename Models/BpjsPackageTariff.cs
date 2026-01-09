using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BpjsPackageTariff
{
    public string PackageID { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public string ClassID { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
