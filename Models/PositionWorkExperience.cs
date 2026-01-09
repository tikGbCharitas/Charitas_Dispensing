using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PositionWorkExperience
{
    public int PositionWorkExperienceID { get; set; }

    public int PositionID { get; set; }

    public string SRRequirement { get; set; } = null!;

    public string SRLineBusiness { get; set; } = null!;

    public int YearExperience { get; set; }

    public string WorkExperienceNotes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
