using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemTransactionItemHistory
{
    public string TransactionNo { get; set; } = null!;

    public string LocationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ReferenceNo { get; set; } = null!;

    public DateTime BalanceDate { get; set; }

    public decimal Balance { get; set; }

    public decimal Price { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public decimal? CostPrice { get; set; }

    public decimal? LastPriceInBaseUnit { get; set; }
}
