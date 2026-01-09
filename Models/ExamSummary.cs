using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ExamSummary
{
    public string ExamSummaryID { get; set; } = null!;

    public string ExamSummaryName { get; set; } = null!;

    public string ExamSummaryNameEng { get; set; } = null!;

    public string SRExamSummaryType { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
