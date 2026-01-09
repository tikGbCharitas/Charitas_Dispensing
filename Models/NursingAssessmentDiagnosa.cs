using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NursingAssessmentDiagnosa
{
    public string QuestionID { get; set; } = null!;

    public string NursingDiagnosaID { get; set; } = null!;

    public string? SRAnswerType { get; set; }

    public string? Operand { get; set; }

    public string? AcceptedText { get; set; }

    public decimal? AcceptedNum { get; set; }

    public bool CheckValue { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public bool? IsUsingRange { get; set; }

    public decimal? AcceptedNum2 { get; set; }

    public int AgeInMonthStart { get; set; }

    public int AgeInMonthEnd { get; set; }

    public virtual NursingDiagnosa NursingDiagnosa { get; set; } = null!;
}
