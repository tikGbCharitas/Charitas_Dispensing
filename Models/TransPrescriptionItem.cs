using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionItem
{
    public string PrescriptionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ParentNo { get; set; } = null!;

    public bool IsRFlag { get; set; }

    public bool IsCompound { get; set; }

    public string ItemID { get; set; } = null!;

    public string ItemInterventionID { get; set; } = null!;

    public string SRItemUnit { get; set; } = null!;

    public string? ItemQtyInString { get; set; }

    public bool? IsUsingDosageUnit { get; set; }

    public string SRDosageUnit { get; set; } = null!;

    public byte? FrequencyOfDosing { get; set; }

    public string? DosingPeriod { get; set; }

    public decimal? NumberOfDosage { get; set; }

    public byte? DurationOfDosing { get; set; }

    public string? ACPCDC { get; set; }

    public string? SRMedicationRoute { get; set; }

    public string? ConsumeMethod { get; set; }

    public decimal PrescriptionQty { get; set; }

    public decimal TakenQty { get; set; }

    public decimal ResultQty { get; set; }

    public decimal CostPrice { get; set; }

    public decimal InitialPrice { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string EmbalaceID { get; set; } = null!;

    public decimal EmbalaceAmount { get; set; }

    public bool? IsUseSweetener { get; set; }

    public decimal? SweetenerAmount { get; set; }

    public decimal LineAmount { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string SRDiscountReason { get; set; } = null!;

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public bool IsBillProceed { get; set; }

    public decimal DurationRelease { get; set; }

    public decimal? RecipeAmount { get; set; }

    public bool? IsCalcPercentage { get; set; }

    public decimal AutoProcessCalculation { get; set; }

    public bool IsUsingAdminReturn { get; set; }

    public string? VerifiedByUserID { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string? LastUpdateByUserHostName { get; set; }

    public string? VerifiedByUserHostName { get; set; }

    public string? SRConsumeMethod { get; set; }

    public string? DosageQty { get; set; }

    public string? EmbalaceQty { get; set; }

    public string? IterText { get; set; }

    public string? OrderText { get; set; }

    public string? ConsumeQty { get; set; }

    public string? SRConsumeUnit { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceSequenceNo { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public decimal? OriPrescriptionQty { get; set; }

    public string? OriConsumeQty { get; set; }

    public string? OriSRConsumeUnit { get; set; }

    public decimal? OriResultQty { get; set; }

    public string? OriItemQtyInString { get; set; }

    public string? OriSRItemUnit { get; set; }

    public string? OriDosageQty { get; set; }

    public string? OriSRDosageUnit { get; set; }

    public string? OriSRConsumeMethod { get; set; }

    public bool? IsReturned { get; set; }

    public bool? IsPendingDelivery { get; set; }

    public decimal? DeliveryQty { get; set; }

    public int? DaysOfUsage { get; set; }

    public virtual TransPrescription PrescriptionNoNavigation { get; set; } = null!;
}
