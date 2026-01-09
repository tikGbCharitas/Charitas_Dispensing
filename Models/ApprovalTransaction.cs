using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ApprovalTransaction
{
    public string TransactionNo { get; set; } = null!;

    public int ApprovalLevel { get; set; }

    public string UserID { get; set; } = null!;

    public string ApprovalRangeID { get; set; } = null!;

    public bool IsApprovalLevelFinal { get; set; }

    public bool IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
