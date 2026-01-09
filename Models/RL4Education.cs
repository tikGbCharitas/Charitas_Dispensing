using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RL4Education
{
    public int RL4EducationID { get; set; }

    public string RL4EducationCode { get; set; } = null!;

    public string RL4EducationName { get; set; } = null!;

    public string? AcademicTitle { get; set; }

    public string SREducationLevel { get; set; } = null!;

    public string SRFieldLabor { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
