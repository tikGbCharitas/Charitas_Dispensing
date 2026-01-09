using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SupplierContractItem
{
    public string TransactionNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string SRPurchaseUnit { get; set; } = null!;

    public decimal PriceInPurchaseUnit { get; set; }

    public decimal PurchaseDiscount1 { get; set; }

    public decimal PurchaseDiscount2 { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual SupplierContract TransactionNoNavigation { get; set; } = null!;
}
