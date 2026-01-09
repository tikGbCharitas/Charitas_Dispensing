using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ClosingAccounting
{
    public string YearNo { get; set; } = null!;

    public string MonthNo { get; set; } = null!;

    public bool? IsClosed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
