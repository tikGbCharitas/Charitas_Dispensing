using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ItemProductMedic
{
    public string ItemID { get; set; } = null!;

    public string? MarginID { get; set; }

    public string SRProductType { get; set; } = null!;

    public string ABCClass { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public string SRItemUnit { get; set; } = null!;

    public string SRPurchaseUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public decimal Dosage { get; set; }

    public string SRDosageUnit { get; set; } = null!;

    public bool IsFormularium { get; set; }

    public bool IsInventoryItem { get; set; }

    public bool IsControlExpired { get; set; }

    public string? FabricID { get; set; }

    public decimal SalesFixedPrice { get; set; }

    public decimal MarginPercentage { get; set; }

    public decimal SalesDiscount { get; set; }

    public decimal PriceInPurchaseUnit { get; set; }

    public decimal PriceInBaseUnit { get; set; }

    public decimal PriceInBasedUnitWVat { get; set; }

    public decimal HighestPriceInBasedUnit { get; set; }

    public decimal CostPrice { get; set; }

    public decimal PurchaseDiscount1 { get; set; }

    public decimal PurchaseDiscount2 { get; set; }

    public decimal SafetyStock { get; set; }

    public byte SafetyTime { get; set; }

    public byte LeadTime { get; set; }

    public decimal TolerancePercentage { get; set; }

    public bool? IsUsingCigna { get; set; }

    public string Barcode { get; set; } = null!;

    public string SRItemBin { get; set; } = null!;

    public string SRDrugLabelType { get; set; } = null!;

    public bool? IsConsignment { get; set; }

    public string? TherapyID { get; set; }

    public bool? IsActualDeduct { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? isGeneric { get; set; }

    public decimal? PremiPharmaciesPercentage { get; set; }

    public decimal? PremiPhysicianPercentage { get; set; }

    public decimal? HET { get; set; }

    public string? SRProductCategory { get; set; }

    public decimal? LastPriceInBaseUnit { get; set; }

    public bool? IsNarcotic { get; set; }

    public bool? IsPsychotropic { get; set; }

    public bool? IsAntibiotic { get; set; }

    public bool? IsRegularItem { get; set; }

    public bool? IsSalesAvailable { get; set; }

    public bool? IsDirectPurchase { get; set; }

    public decimal PriceWVat { get; set; }

    public bool? IsPrecursor { get; set; }

    public string? SRTherapyGroup { get; set; }

    public string? Keeping { get; set; }

    public bool? IsMorphine { get; set; }

    public string? SRKeeping { get; set; }

    public string? VENClass { get; set; }

    public bool? IsHam { get; set; }

    public bool? IsLasa { get; set; }

    public bool? IsOot { get; set; }

    public bool? IsSharePurchaseDiscToPatient { get; set; }

    public bool? IsFornas { get; set; }

    public bool? IsMedication { get; set; }

    public int? ConsumptionLimitInDay { get; set; }

    public bool? IsNonGeneric { get; set; }

    public bool? IsAso { get; set; }

    public string? SRSpecificInfo { get; set; }

    public string? RestrictionNotes { get; set; }

    public virtual Item Item { get; set; } = null!;
}
