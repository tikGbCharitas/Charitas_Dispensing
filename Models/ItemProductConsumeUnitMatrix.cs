using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductConsumeUnitMatrix
{
    public string ItemID { get; set; } = null!;

    public string SRItemUnit { get; set; } = null!;

    public string SRConsumeUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
