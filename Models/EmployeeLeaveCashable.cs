using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeLeaveCashable
{
    public int EmployeeLeaveCashableID { get; set; }

    public int PayrollPeriodID { get; set; }

    public int PersonID { get; set; }

    public int SalaryComponentID { get; set; }

    public int TotalDay { get; set; }

    public string? LetterNumber { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
