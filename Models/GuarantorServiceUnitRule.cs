using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorServiceUnitRule
{
    public string GuarantorID { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public bool? IsCovered { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
