using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class QuestionGroup
{
    public string QuestionGroupID { get; set; } = null!;

    public string QuestionGroupName { get; set; } = null!;

    public string? QuestionGroupNameEN { get; set; }

    public int? OrderNo { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SoapType { get; set; }
}
