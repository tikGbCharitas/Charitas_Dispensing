using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionItemTemplate
{
    public string TemplateNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ParentNo { get; set; } = null!;

    public bool IsRFlag { get; set; }

    public bool IsCompound { get; set; }

    public string ItemID { get; set; } = null!;

    public string SRItemUnit { get; set; } = null!;

    public string? ItemQtyInString { get; set; }

    public string SRDosageUnit { get; set; } = null!;

    public decimal PrescriptionQty { get; set; }

    public decimal TakenQty { get; set; }

    public decimal ResultQty { get; set; }

    public string EmbalaceID { get; set; } = null!;

    public decimal EmbalaceAmount { get; set; }

    public string Notes { get; set; } = null!;

    public string? SRConsumeMethod { get; set; }

    public string? DosageQty { get; set; }

    public string? EmbalaceQty { get; set; }

    public string? ConsumeQty { get; set; }

    public string? SRConsumeUnit { get; set; }

    public DateTime LastCreateDateTime { get; set; }

    public string LastCreateUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? SRMedicationConsume { get; set; }
}
