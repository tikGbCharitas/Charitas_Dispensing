using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SalaryComponentRounding
{
    public int SalaryComponentRoundingID { get; set; }

    public string SalaryComponentRoundingName { get; set; } = null!;

    public decimal NominalValue { get; set; }

    public decimal NearestValue { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public int? Formula { get; set; }
}
