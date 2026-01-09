using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesItemConsumption
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string DetailItemID { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal? QtyRealization { get; set; }

    public string SRItemUnit { get; set; } = null!;

    public decimal? Price { get; set; }

    public decimal? AveragePrice { get; set; }

    public decimal? FifoPrice { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public bool? IsPackage { get; set; }
}
