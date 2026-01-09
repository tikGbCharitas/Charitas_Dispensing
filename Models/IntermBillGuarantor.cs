using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class IntermBillGuarantor
{
    public string GuarantorID { get; set; } = null!;

    public string IntermBillNo { get; set; } = null!;

    public decimal? Amount { get; set; }

    public decimal? DiscoutAmount { get; set; }

    public decimal? AdmAmount { get; set; }

    public decimal? AdmAmountDisc { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? AdmAdjustmentAmount { get; set; }

    public decimal? AdmAdjustmentAmountDisc { get; set; }
}
