using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PathologyAnatomyDiagnosis
{
    public string ResultType { get; set; } = null!;

    public string DiagnosisID { get; set; } = null!;

    public string? DiagnosisName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
