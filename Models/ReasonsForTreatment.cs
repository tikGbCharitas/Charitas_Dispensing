using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ReasonsForTreatment
{
    public string SRReasonVisit { get; set; } = null!;

    public string ReasonsForTreatmentID { get; set; } = null!;

    public string ReasonsForTreatmentName { get; set; } = null!;

    public string? DiagnoseID { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
