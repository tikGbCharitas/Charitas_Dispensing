using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorItemPrescriptionRule
{
    public string GuarantorID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string? SRGuarantorRuleType { get; set; }

    public decimal AmountValue { get; set; }

    public bool IsValueInPercent { get; set; }

    public bool IsInclude { get; set; }

    public bool? IsToGuarantor { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? OutpatientAmountValue { get; set; }

    public decimal? EmergencyAmountValue { get; set; }
}
