using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class VitalSignews
{
    public string VitalSignID { get; set; } = null!;

    public int StartAgeInDay { get; set; }

    public int IndexNo { get; set; }

    public int ChartMinValue { get; set; }

    public int ChartMaxValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsExcludeFromScoreEws { get; set; }
}
