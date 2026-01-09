using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemOptic
{
    public string ItemID { get; set; } = null!;

    public string? MarginID { get; set; }

    public string SRProductType { get; set; } = null!;

    public string ABCClass { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public string SRItemUnit { get; set; } = null!;

    public string SRPurchaseUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public bool IsInventoryItem { get; set; }

    public string? FabricID { get; set; }

    public decimal SalesFixedPrice { get; set; }

    public decimal MarginPercentage { get; set; }

    public decimal SalesDiscount { get; set; }

    public decimal PriceInPurchaseUnit { get; set; }

    public decimal PriceInBaseUnit { get; set; }

    public decimal PriceInBasedUnitWVat { get; set; }

    public decimal HighestPriceInBasedUnit { get; set; }

    public decimal CostPrice { get; set; }

    public decimal TolerancePercentage { get; set; }

    public string Barcode { get; set; } = null!;

    public string SRItemBin { get; set; } = null!;

    public bool? IsConsignment { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual Item Item { get; set; } = null!;
}
