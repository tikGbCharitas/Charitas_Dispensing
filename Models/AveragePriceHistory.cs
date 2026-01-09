using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AveragePriceHistory
{
    public string TransactionNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ItemUnit { get; set; } = null!;

    public DateTime ChangedDate { get; set; }

    public string TransactionCode { get; set; } = null!;

    public decimal OldAveragePrice { get; set; }

    public decimal NewAveragePrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
