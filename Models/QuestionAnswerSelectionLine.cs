using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class QuestionAnswerSelectionLine
{
    public string QuestionAnswerSelectionID { get; set; } = null!;

    public string QuestionAnswerSelectionLineID { get; set; } = null!;

    public string QuestionAnswerSelectionLineText { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? Score { get; set; }
}
