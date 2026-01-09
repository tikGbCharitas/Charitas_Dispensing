using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TmpItemBalanceEndOfTheMonth
{
    public DateOnly TransactionDate { get; set; }

    public string LocationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal Balance { get; set; }

    public string? SRItemUnit { get; set; }

    public decimal? CostPrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
