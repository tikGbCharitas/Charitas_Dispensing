using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemBalanceDetail
{
    public string LocationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ReferenceNo { get; set; } = null!;

    public string? TransactionCode { get; set; }

    public DateTime BalanceDate { get; set; }

    public decimal Balance { get; set; }

    public decimal Booking { get; set; }

    public decimal Price { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? PurchaseReceiveNo { get; set; }
}
