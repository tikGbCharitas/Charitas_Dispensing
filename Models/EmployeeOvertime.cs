using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeOvertime
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public int PayrollPeriodID { get; set; }

    public int SupervisorID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string? VerifiedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
