using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Pkp
{
    public int PkpID { get; set; }

    public DateTime ValidFrom { get; set; }

    public bool? IsNPWP { get; set; }

    public decimal LowerLimit { get; set; }

    public decimal UpperLimit { get; set; }

    public decimal TaxRate { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal AmountOfDeduction { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
