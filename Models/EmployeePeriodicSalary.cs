using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeePeriodicSalary
{
    public int EmployeePeriodicSalaryID { get; set; }

    public int PayrollPeriodID { get; set; }

    public int PersonID { get; set; }

    public int SalaryComponentID { get; set; }

    public string SRProcessType { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public decimal? FromBasicSalaryAmount { get; set; }

    public int? FromPositionGradeID { get; set; }

    public int? ToPositionGradeID { get; set; }

    public int? FromGradeYear { get; set; }

    public int? ToGradeYear { get; set; }

    public decimal? OvertimeAmount { get; set; }

    public DateTime? TransactionDate { get; set; }
}
