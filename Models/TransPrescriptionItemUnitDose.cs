using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionItemUnitDose
{
    public string PrescriptionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ReferenceNo { get; set; } = null!;

    public string ReferenceSequenceNo { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public string ItemID { get; set; } = null!;

    public decimal ResultQty { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal EmbalaceAmount { get; set; }

    public decimal SweetenerAmount { get; set; }

    public decimal LineAmount { get; set; }

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public bool IsBillProceed { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
