using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AuditLogDatum
{
    public int AuditLogID { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }
}
