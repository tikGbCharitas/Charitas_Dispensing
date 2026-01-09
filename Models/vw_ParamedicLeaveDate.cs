using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_ParamedicLeaveDate
{
    public string ParamedicID { get; set; } = null!;

    public DateTime LeaveDate { get; set; }
}
