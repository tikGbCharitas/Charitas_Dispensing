using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ReasonsForTreatmentDesc
{
    public string SRReasonVisit { get; set; } = null!;

    public string ReasonsForTreatmentID { get; set; } = null!;

    public string ReasonsForTreatmentDescID { get; set; } = null!;

    public string ReasonsForTreatmentDescName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
