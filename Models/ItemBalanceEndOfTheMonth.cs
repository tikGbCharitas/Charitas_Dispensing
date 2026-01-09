using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemBalanceEndOfTheMonth
{
    public DateOnly TransactionDate { get; set; }

    public string LocationID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public decimal Balance { get; set; }

    public string? SRItemUnit { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? PriceInBaseUnit { get; set; }

    public decimal? PriceInBasedUnitWVat { get; set; }

    public decimal? QtyUsagePerDay { get; set; }

    public decimal? QtyUsagePerMonth { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? PurchaseDiscount1 { get; set; }

    public decimal? PurchaseDiscount2 { get; set; }

    public decimal? LastPriceInBaseUnit { get; set; }

    public decimal? BalanceItemMovement { get; set; }
}
