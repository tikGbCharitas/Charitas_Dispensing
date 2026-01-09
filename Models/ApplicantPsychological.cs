using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ApplicantPsychological
{
    public int ApplicantPsychologicalID { get; set; }

    public int ApplicantID { get; set; }

    public string SRPsychological { get; set; } = null!;

    public string SROperandType { get; set; } = null!;

    public string PsychologicalValue { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
