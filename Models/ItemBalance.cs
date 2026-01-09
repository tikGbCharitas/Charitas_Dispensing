using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemBalance
{
    public string LocationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ReorderType { get; set; } = null!;

    public decimal Minimum { get; set; }

    public decimal Maximum { get; set; }

    public decimal Balance { get; set; }

    public decimal Booking { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SRItemBin { get; set; }
}
