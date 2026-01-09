using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicLeaveExeptionUnit
{
    public string TransactionNo { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
