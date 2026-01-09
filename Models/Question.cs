using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Question
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

    public bool? IsActive { get; set; }

    public int? AnswerWidth { get; set; }

    public int? AnswerWidth2 { get; set; }

    public string? QuestionAnswerSelectionID { get; set; }

    public string? QuestionAnswerDefaultSelectionID { get; set; }

    public string? QuestionAnswerSelectionID2 { get; set; }

    public string? QuestionAnswerDefaultSelectionID2 { get; set; }

    public string? Formula { get; set; }

    public bool? IsAlwaysPrint { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsMandatory { get; set; }

    public string? ReferenceQuestionID { get; set; }

    public string? VitalSignID { get; set; }

    public string? BodyID { get; set; }

    public string? RelatedEntityName { get; set; }

    public string? RelatedColumnName { get; set; }

    public string? LookUpID { get; set; }

    public bool? IsUpdateRelatedEntity { get; set; }

    public bool? IsReadOnly { get; set; }

    public string? NursingDisplayAs { get; set; }

    public string? EquivalentQuestionID { get; set; }
}
