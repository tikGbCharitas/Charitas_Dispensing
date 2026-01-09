using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_ItemProductMedicNonMedic
{
    public string ItemID { get; set; } = null!;

    public string SRItemUnit { get; set; } = null!;

    public string SRPurchaseUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public bool IsInventoryItem { get; set; }

    public decimal PriceInPurchaseUnit { get; set; }

    public decimal PriceInBaseUnit { get; set; }

    public decimal PriceInBasedUnitWVat { get; set; }

    public decimal HighestPriceInBasedUnit { get; set; }

    public decimal CostPrice { get; set; }

    public int? IsRegularItem { get; set; }

    public bool? IsSalesAvailable { get; set; }

    public string BrandName { get; set; } = null!;

    public decimal Dosage { get; set; }

    public string SRDosageUnit { get; set; } = null!;

    public int? IsUsingCigna { get; set; }

    public string SRDrugLabelType { get; set; } = null!;

    public string GenericFlag { get; set; } = null!;
}
