using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AuditLogSetting
{
    public string TableName { get; set; } = null!;

    public string TableDescription { get; set; } = null!;

    public bool IsAuditLog { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsConsolidationBranchToHO { get; set; }

    public bool? IsConsolidationHOToBranch { get; set; }
}
