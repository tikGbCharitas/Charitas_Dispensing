using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeGrade
{
    public int EmployeeGradeID { get; set; }

    public int PersonID { get; set; }

    public int EmployeeGradeMasterID { get; set; }

    public int SalaryTableNumber { get; set; }

    public bool IsActive { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
