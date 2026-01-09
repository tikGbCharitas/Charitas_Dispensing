using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TmpItemRequestMaintenance
{
    public string UserID { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public string ToServiceUnitID { get; set; } = null!;

    public string FollowUpID { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public string? SRItemUnit { get; set; }

    public decimal? ConversionFactor { get; set; }
}
