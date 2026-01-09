using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class _bak_PatientHealthRecordLine_20210128
{
    public string TransactionNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string QuestionFormID { get; set; } = null!;

    public string QuestionGroupID { get; set; } = null!;

    public string QuestionID { get; set; } = null!;

    public string? QuestionAnswerPrefix { get; set; }

    public string? QuestionAnswerSuffix { get; set; }

    public string? QuestionAnswerSelectionLineID { get; set; }

    public string? QuestionAnswerText { get; set; }

    public decimal? QuestionAnswerNum { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? QuestionAnswerText2 { get; set; }

    public byte[]? BodyImage { get; set; }
}
