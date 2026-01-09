using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationTariffComponentDiscountRuleGuarantor
{
    public string RegistrationNo { get; set; } = null!;

    public string GuarantorID { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public bool? IsDiscountInPercentage { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
