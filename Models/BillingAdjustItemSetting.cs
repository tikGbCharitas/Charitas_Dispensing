using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BillingAdjustItemSetting
{
    public int Id { get; set; }

    public string? ParamedicID { get; set; }

    public string? SRSpecialty { get; set; }

    public string? SRTariffType { get; set; }

    public string? GuarantorID { get; set; }

    public string? SRRegistrationType { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? ItemGroupID { get; set; }

    public string? ItemID { get; set; }

    public string? ClassID { get; set; }

    public string? TariffComponentID { get; set; }

    public bool IsFeeValueInPercent { get; set; }

    public decimal? FeeValue { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
