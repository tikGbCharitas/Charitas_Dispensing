using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeLeaveRequest
{
    public long LeaveRequestID { get; set; }

    public DateTime RequestDate { get; set; }

    public int PersonID { get; set; }

    public long EmployeeLeaveID { get; set; }

    public DateTime RequestLeaveDateFrom { get; set; }

    public DateTime RequestLeaveDateTo { get; set; }

    public int RequestDays { get; set; }

    public DateTime RequestWorkingDate { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? VerifiedDate { get; set; }

    public bool? IsRequestApproved { get; set; }

    public DateTime? ApprovedLeaveDateFrom { get; set; }

    public DateTime? ApprovedLeaveDateTo { get; set; }

    public int? ApprovedDays { get; set; }

    public DateTime? ApprovedWorkingDate { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string? VerifiedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
