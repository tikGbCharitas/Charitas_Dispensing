using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductMarginValue
{
    public string MarginID { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public decimal StartingValue { get; set; }

    public decimal EndingValue { get; set; }

    public decimal MarginPercentage { get; set; }

    public bool IsMinusDiscount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? OTCMarginPercentage { get; set; }

    public decimal? OutpatientMarginPercentage { get; set; }

    public decimal? InpatientMarginPercentage { get; set; }

    public virtual ItemProductMargin Margin { get; set; } = null!;
}
