using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class QuestionAnswerSelection
{
    public string QuestionAnswerSelectionID { get; set; } = null!;

    public string? QuestionAnswerSelectionText { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
