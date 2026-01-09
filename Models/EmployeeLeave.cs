using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeLeave
{
    public long EmployeeLeaveID { get; set; }

    public int PersonID { get; set; }

    public string SREmployeeLeaveType { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int LeaveEntitlementsQty { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
