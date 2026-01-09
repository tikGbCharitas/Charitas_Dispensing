using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalWorkExperience
{
    public int PersonalWorkExperienceID { get; set; }

    public int PersonID { get; set; }

    public string SRLineBisnis { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Company { get; set; }

    public string? Division { get; set; }

    public string? Location { get; set; }

    public string? JobDesc { get; set; }

    public string? SupervisorName { get; set; }

    public decimal? LastSalary { get; set; }

    public string? ReasonOfLeaving { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
