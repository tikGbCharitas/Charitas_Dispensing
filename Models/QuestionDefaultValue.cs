using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class QuestionDefaultValue
{
    public string QuestionFormID { get; set; } = null!;

    public string QuestionGroupID { get; set; } = null!;

    public string QuestionID { get; set; } = null!;

    public string? FromQuestionFormID { get; set; }

    public string? FromQuestionGroupID { get; set; }

    public string FromQuestionID { get; set; } = null!;

    public bool? IsFromCurrentRegistration { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
