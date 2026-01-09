using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WageTransaction
{
    public long WageTransactionID { get; set; }

    public int WageProcessTypeID { get; set; }

    public int PayrollPeriodID { get; set; }

    public DateTime TransactionDate { get; set; }

    public int PersonID { get; set; }

    public string SREmployeeType { get; set; } = null!;

    public string SRRemunerationType { get; set; } = null!;

    public int OrganizationUnitID { get; set; }

    public int SubOrganizationUnitID { get; set; }

    public string SRPaymentFrequency { get; set; } = null!;

    public string SRTaxStatus { get; set; } = null!;

    public string? SREmployeeStatus { get; set; }

    public int? PositionID { get; set; }

    public string? SRReligion { get; set; }

    public string? SREmploymentType { get; set; }

    public int? PositionGradeID { get; set; }

    public string? SRMaritalStatus { get; set; }

    public int? ServiceYear { get; set; }

    public int? SalaryTableNumber { get; set; }

    public int? EmployeeGradeID { get; set; }

    public int? NoOfDependent { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public bool? IsKWI { get; set; }

    public string? SREducationLevel { get; set; }
}
