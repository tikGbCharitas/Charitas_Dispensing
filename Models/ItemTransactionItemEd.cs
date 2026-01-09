using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTransactionItemEd
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public DateTime ExpiredDate { get; set; }

    public string BatchNumber { get; set; } = null!;

    public string? ItemID { get; set; }

    public decimal? Quantity { get; set; }

    public string? SRItemUnit { get; set; }

    public decimal? ConversionFactor { get; set; }

    public decimal? QuantityFinishInBaseUnit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
