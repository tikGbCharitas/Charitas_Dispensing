using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalRecruitmentTest
{
    public int PersonalRecruitmentTestID { get; set; }

    public int PersonID { get; set; }

    public DateTime TestDate { get; set; }

    public string SRRecruitmentTest { get; set; } = null!;

    public string TestResult { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
