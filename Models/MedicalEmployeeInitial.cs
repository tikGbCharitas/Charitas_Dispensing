using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalEmployeeInitial
{
    public int MedicalEmployeeInitialID { get; set; }

    public int PersonID { get; set; }

    public string Year { get; set; } = null!;

    public decimal EmployeeUsedAmount { get; set; }

    public decimal DependentUsedAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
