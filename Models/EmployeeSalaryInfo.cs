using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeSalaryInfo
{
    public int PersonID { get; set; }

    public string? Npwp { get; set; }

    public string SRPaymentFrequency { get; set; } = null!;

    public string SRTaxStatus { get; set; } = null!;

    public string? BankID { get; set; }

    public string BankAccountNo { get; set; } = null!;

    public int NoOfDependent { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? JamsostekNo { get; set; }

    public string? SREmployeeType { get; set; }

    public bool? IsSalaryManaged { get; set; }
}
