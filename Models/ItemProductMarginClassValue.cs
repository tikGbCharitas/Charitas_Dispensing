using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductMarginClassValue
{
    public string MarginID { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public decimal MarginValuePercentage { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
