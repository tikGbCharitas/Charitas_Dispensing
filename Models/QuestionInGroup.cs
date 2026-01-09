using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class QuestionInGroup
{
    public string QuestionGroupID { get; set; } = null!;

    public string QuestionID { get; set; } = null!;

    public int RowIndex { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public int? PageNo { get; set; }

    public string? ParentQuestionID { get; set; }

    public int? QuestionLevel { get; set; }
}
