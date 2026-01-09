using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeMedicalAdjustment
{
    public int EmployeeMedicalAdjustmentID { get; set; }

    public int PersonID { get; set; }

    public int YearPeriodID { get; set; }

    public int MedicalBenefitInfoID { get; set; }

    public DateTime AdjustmentDate { get; set; }

    public decimal AdjustmentAmount { get; set; }

    public decimal DependentAdjustmentAmount { get; set; }

    public bool IsApproved { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
