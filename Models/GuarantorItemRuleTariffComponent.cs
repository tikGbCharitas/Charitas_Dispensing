using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorItemRuleTariffComponent
{
    public string GuarantorID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public decimal AmountValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? OutpatientAmountValue { get; set; }

    public decimal? EmergencyAmountValue { get; set; }
}
