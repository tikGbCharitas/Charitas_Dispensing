using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeTaxCalculationHd
{
    public string VerificationNo { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public short Period { get; set; }

    public decimal GrossAccumulation { get; set; }

    public decimal TaxBaseGrossAccumulation { get; set; }

    public decimal AccumulationTax { get; set; }

    public decimal AccumulationOfRecentTax { get; set; }

    public decimal TaxToBePaid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
