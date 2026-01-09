using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssessmentTypeBodyDiagram
{
    public string SRAssessmentType { get; set; } = null!;

    public string BodyID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
