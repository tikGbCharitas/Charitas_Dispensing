using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeSalaryMatrix
{
    public long EmployeeSalaryMatrixID { get; set; }

    public int PersonID { get; set; }

    public int SalaryComponentID { get; set; }

    public int Qty { get; set; }

    public decimal NominalAmount { get; set; }

    public string SRCurrencyCode { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
