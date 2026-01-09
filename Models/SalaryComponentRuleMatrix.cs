using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SalaryComponentRuleMatrix
{
    public int SalaryComponentRuleMatrixID { get; set; }

    public int SalaryComponentID { get; set; }

    public int SalaryRuleComponentID { get; set; }

    public string SROperandType { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
