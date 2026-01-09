using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeePeriodicStructuralBenefit
{
    public int CounterID { get; set; }

    public int PayrollPeriodID { get; set; }

    public int SalaryComponentID { get; set; }

    public int PersonID { get; set; }

    public int OrganizationUnitID { get; set; }

    public int PositionID { get; set; }

    public string? SRStructuralBenefitsType { get; set; }

    public decimal? Amount { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? NumberOfDays { get; set; }
}
