using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppProgramHealthcare
{
    public string ProgramID { get; set; } = null!;

    public string HealthcareID { get; set; } = null!;

    public string? NavigateUrl { get; set; }

    public string? AssemblyName { get; set; }

    public string? AssemblyClassName { get; set; }

    public string? StoreProcedureName { get; set; }

    public string? ProgramType { get; set; }

    public bool? IsUsingReportHeader { get; set; }

    public bool? IsDirectPrintEnable { get; set; }

    public string? HelpLinkID { get; set; }
}
