using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ExamSummaryResult
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string SRExamSummaryType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int OrderIndex { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
