using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeDeductionSetting
{
    public int DeductionID { get; set; }

    public string? SRParamedicFeeDeduction { get; set; }

    public string? SRRegistrationType { get; set; }

    public string GuarantorID { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string SRParamedicFeeDeductionMethod { get; set; } = null!;

    public bool IsDeductionValueInPercent { get; set; }

    public decimal DeductionValue { get; set; }

    public bool? IsActive { get; set; }

    public string CreatedByUserID { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string? SRGuarantorType { get; set; }

    public bool? IsMainPhysicianOnly { get; set; }

    public string? TariffComponentID { get; set; }

    public bool? IsAfterTax { get; set; }

    public virtual ICollection<ParamedicFeeDeduction> ParamedicFeeDeductions { get; set; } = new List<ParamedicFeeDeduction>();
}
