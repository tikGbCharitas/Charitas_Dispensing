using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalEducationHistory
{
    public int PersonalEducationHistoryID { get; set; }

    public int PersonID { get; set; }

    public string SREducationLevel { get; set; } = null!;

    public string InstitutionName { get; set; } = null!;

    public string? Location { get; set; }

    public string? StartYear { get; set; }

    public string? EndYear { get; set; }

    public decimal? Gpa { get; set; }

    public string? Achievement { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
