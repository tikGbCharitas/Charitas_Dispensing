using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationDiscountRuleGuarantor
{
    public string RegistrationNo { get; set; } = null!;

    public string GuarantorID { get; set; } = null!;

    public decimal? ResepPercentage { get; set; }

    public bool? IsDiscountGlobal { get; set; }

    public bool? IsDiscountGlobalInPercent { get; set; }

    public decimal? DiscountGlobalAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? ItemMedicalPercentage { get; set; }

    public decimal? ItemNonMedicalPercentage { get; set; }
}
