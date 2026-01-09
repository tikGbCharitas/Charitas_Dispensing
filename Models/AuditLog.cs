using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AuditLog
{
    public int AuditLogID { get; set; }

    public string TableName { get; set; } = null!;

    public string AuditActionType { get; set; } = null!;

    public string PrimaryKeyData { get; set; } = null!;

    public string ActionByUserID { get; set; } = null!;

    public DateTime LogDateTime { get; set; }
}
