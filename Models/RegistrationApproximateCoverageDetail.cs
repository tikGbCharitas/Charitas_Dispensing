using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationApproximateCoverageDetail
{
    public string RegistrationNo { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public decimal CoverageAmount { get; set; }

    public decimal CalculatedAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string DiagnoseID { get; set; } = null!;

    public string? ProcedureID { get; set; }

    public string? DiagnoseID2 { get; set; }

    public string? DiagnoseID3 { get; set; }

    public string? ProcedureID2 { get; set; }

    public string? Notes { get; set; }

    public string? NotesCmx { get; set; }
}
