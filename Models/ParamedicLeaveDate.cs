using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicLeaveDate
{
    public string TransactionNo { get; set; } = null!;

    public DateTime LeaveDate { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
