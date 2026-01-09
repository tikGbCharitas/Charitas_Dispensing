using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AnalysisDocument
{
    public string RegistrationNo { get; set; } = null!;

    public string SRFilesAnalysis { get; set; } = null!;

    public DateTime FilesReceiveDate { get; set; }

    public DateTime? FilesAcceptanceDate { get; set; }

    public string ParamedicID { get; set; } = null!;

    public string? SRCompleteStatusRM { get; set; }

    public string? Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
