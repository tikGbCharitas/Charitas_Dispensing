using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationItemRule
{
    public string RegistrationNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string? SRGuarantorRuleType { get; set; }

    public decimal AmountValue { get; set; }

    public bool? IsValueInPercent { get; set; }

    public bool? IsInclude { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsToGuarantor { get; set; }

    public decimal? OutpatientAmountValue { get; set; }

    public decimal? EmergencyAmountValue { get; set; }

    public bool? IsByItemID { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
