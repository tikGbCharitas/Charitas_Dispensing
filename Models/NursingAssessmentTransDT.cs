using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NursingAssessmentTransDT
{
    public long ID { get; set; }

    public long HDID { get; set; }

    public string QuestionID { get; set; } = null!;

    public string QuestionText { get; set; } = null!;

    public bool IsSubjective { get; set; }

    public bool IsObjective { get; set; }

    public string? AnswerPrefix { get; set; }

    public string? AnswerSuffix { get; set; }

    public string? AnswerText { get; set; }

    public decimal? AnswerNum { get; set; }

    public string? AnswerSelectionLineID { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
