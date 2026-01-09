using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ChargeBedAutoBillMatrix
{
    public string SequenceNo { get; set; } = null!;

    public decimal MinHour { get; set; }

    public decimal MaxHour { get; set; }

    public decimal PercentageAmount { get; set; }

    public decimal ValueAmount { get; set; }
}
