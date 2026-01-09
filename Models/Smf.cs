using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Smf
{
    public string SmfID { get; set; } = null!;

    public string SmfName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SRParamedicFeeCaseType { get; set; }

    public string? SRAssessmentType { get; set; }
}
