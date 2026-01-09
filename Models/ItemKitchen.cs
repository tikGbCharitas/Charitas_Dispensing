using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemKitchen
{
    public string ItemID { get; set; } = null!;

    public string ABCClass { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public string SRItemUnit { get; set; } = null!;

    public string SRPurchaseUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public bool IsInventoryItem { get; set; }

    public bool IsControlExpired { get; set; }

    public decimal PriceInPurchaseUnit { get; set; }

    public decimal PriceInBaseUnit { get; set; }

    public decimal PriceInBasedUnitWVat { get; set; }

    public decimal HighestPriceInBasedUnit { get; set; }

    public decimal LastPriceInBaseUnit { get; set; }

    public decimal PriceWVat { get; set; }

    public decimal CostPrice { get; set; }

    public decimal PurchaseDiscount1 { get; set; }

    public decimal PurchaseDiscount2 { get; set; }

    public decimal SafetyStock { get; set; }

    public byte SafetyTime { get; set; }

    public byte LeadTime { get; set; }

    public decimal TolerancePercentage { get; set; }

    public string Barcode { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsSalesAvailable { get; set; }

    public decimal? SalesFixedPrice { get; set; }

    public decimal? MarginPercentage { get; set; }

    public string? MarginID { get; set; }

    public virtual Item Item { get; set; } = null!;
}
