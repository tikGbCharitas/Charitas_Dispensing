using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NutritionCareAssessmentQuestion
{
    public string QuestionID { get; set; } = null!;

    public string? ParentQuestionID { get; set; }

    public int? IndexNo { get; set; }

    public int? QuestionLevel { get; set; }

    public string QuestionText { get; set; } = null!;

    public string? QuestionShortText { get; set; }

    public string SRAnswerType { get; set; } = null!;

    public int? AnswerDecimalDigit { get; set; }

    public string? AnswerPrefix { get; set; }

    public string? AnswerSuffix { get; set; }

    public int? AnswerWidth { get; set; }

    public int? AnswerWidth2 { get; set; }

    public string? QuestionAnswerSelectionID { get; set; }

    public string? QuestionAnswerDefaultSelectionID { get; set; }

    public string? QuestionAnswerSelectionID2 { get; set; }

    public string? QuestionAnswerDefaultSelectionID2 { get; set; }

    public string? Formula { get; set; }

    public bool? IsAlwaysPrint { get; set; }

    public bool? IsMandatory { get; set; }

    public bool IsSubjective { get; set; }

    public bool IsObjective { get; set; }

    public string? RelatedQuestionID { get; set; }

    public bool? IsActive { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
