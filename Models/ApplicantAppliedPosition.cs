using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ApplicantAppliedPosition
{
    public int ApplicantAppliedPositionsID { get; set; }

    public int ApplicantID { get; set; }

    public int PositionID { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
