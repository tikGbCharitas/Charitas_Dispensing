using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NursingAssessment
{
    public string NursingAssessmentID { get; set; } = null!;

    public string NursingAssessmentName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsSubjective { get; set; }

    public bool IsObjective { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string? QuestionID { get; set; }
}
