using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class StandardSalaryFaktor
{
    public int StandardSalaryFaktorID { get; set; }

    public int StandardSalaryID { get; set; }

    public int GradeServiceYear { get; set; }

    public decimal AmountSalary { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
