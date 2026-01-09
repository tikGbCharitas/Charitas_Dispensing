using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeTaxCalculationDt
{
    public string VerificationNo { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public short Period { get; set; }

    public decimal Percentage { get; set; }

    public decimal Gross { get; set; }

    public decimal TaxBaseGross { get; set; }

    public decimal AccumulationTax { get; set; }

    public decimal TaxToBePaid { get; set; }

    public int? CounterID { get; set; }
}
