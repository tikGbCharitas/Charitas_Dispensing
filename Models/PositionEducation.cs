using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionEducation
{
    public int PositionEducationID { get; set; }

    public int PositionID { get; set; }

    public string SRRequirement { get; set; } = null!;

    public string SREducationLevel { get; set; } = null!;

    public string SREducationField { get; set; } = null!;

    public string? EducationNotes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
