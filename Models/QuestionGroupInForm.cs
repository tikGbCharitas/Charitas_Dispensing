using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class QuestionGroupInForm
{
    public string QuestionFormID { get; set; } = null!;

    public string QuestionGroupID { get; set; } = null!;

    public int RowIndex { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
