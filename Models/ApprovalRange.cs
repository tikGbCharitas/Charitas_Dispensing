using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ApprovalRange
{
    public string ApprovalRangeID { get; set; } = null!;

    public string SRItemType { get; set; } = null!;

    public decimal AmountFrom { get; set; }

    public int ApprovalLevelFinal { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
