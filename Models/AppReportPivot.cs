using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppReportPivot
{
    public string ProgramID { get; set; } = null!;

    public int CustomPivotID { get; set; }

    public string FieldCaption { get; set; } = null!;

    public string? UserID { get; set; }

    public int PivotArea { get; set; }

    public int IndexNo { get; set; }

    public string FieldName { get; set; } = null!;

    public int? GroupInterval { get; set; }

    public int? SummaryType { get; set; }

    public int? FormatType { get; set; }

    public string? FormatString { get; set; }
}
