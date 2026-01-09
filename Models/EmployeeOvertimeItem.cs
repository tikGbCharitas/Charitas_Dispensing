using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeOvertimeItem
{
    public string TransactionNo { get; set; } = null!;

    public int PersonID { get; set; }

    public int SalaryComponentID { get; set; }

    public decimal Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
