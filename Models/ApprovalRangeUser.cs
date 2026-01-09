using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ApprovalRangeUser
{
    public string ApprovalRangeID { get; set; } = null!;

    public int ApprovalLevel { get; set; }

    public string UserID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
