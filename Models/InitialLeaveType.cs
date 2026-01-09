using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class InitialLeaveType
{
    public int InitialLeaveTypeID { get; set; }

    public string LeaveTypeName { get; set; } = null!;
}
