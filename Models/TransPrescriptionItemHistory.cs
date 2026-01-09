using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionItemHistory
{
    public string RecalculationProcessNo { get; set; } = null!;

    public string PrescriptionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ParentNo { get; set; } = null!;

    public bool IsRFlag { get; set; }

    public bool IsCompound { get; set; }

    public string ItemID { get; set; } = null!;

    public string ItemInterventionID { get; set; } = null!;

    public string SRItemUnit { get; set; } = null!;

    public string ItemQtyInString { get; set; } = null!;

    public bool IsUsingDosageUnit { get; set; }

    public string SRDosageUnit { get; set; } = null!;

    public byte FrequencyOfDosing { get; set; }

    public string DosingPeriod { get; set; } = null!;

    public decimal NumberOfDosage { get; set; }

    public byte DurationOfDosing { get; set; }

    public string ACPCDC { get; set; } = null!;

    public string SRMedicationRoute { get; set; } = null!;

    public string ConsumeMethod { get; set; } = null!;

    public decimal PrescriptionQty { get; set; }

    public decimal TakenQty { get; set; }

    public decimal ResultQty { get; set; }

    public decimal CostPrice { get; set; }

    public decimal InitialPrice { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string EmbalaceID { get; set; } = null!;

    public decimal EmbalaceAmount { get; set; }

    public bool IsUseSweetener { get; set; }

    public decimal SweetenerAmount { get; set; }

    public decimal LineAmount { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string SRDiscountReason { get; set; } = null!;

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public bool IsBillProceed { get; set; }

    public decimal DurationRelease { get; set; }

    public decimal AutoProcessCalculation { get; set; }

    public string? ConsumeMethodText { get; set; }
}
