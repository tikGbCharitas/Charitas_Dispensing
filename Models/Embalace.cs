using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Embalace
{
    public string EmbalaceID { get; set; } = null!;

    public string EmbalaceName { get; set; } = null!;

    public string EmbalaceLabel { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? EmbalaceFeeAmount { get; set; }
}
