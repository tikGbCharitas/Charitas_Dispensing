using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeLoanItem
{
    public int EmployeeLoanDetailID { get; set; }

    public int EmployeeLoanID { get; set; }

    public int InstallmentNumber { get; set; }

    public DateTime PlanDate { get; set; }

    public decimal PlanAmount { get; set; }

    public decimal MainPayment { get; set; }

    public decimal InterestPayment { get; set; }

    public DateTime? ActualDate { get; set; }

    public decimal? ActualAmount { get; set; }

    public int PayrollPeriodID { get; set; }

    public bool IsPaid { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
