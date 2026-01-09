using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Procedure_old
{
    public string ProcedureID { get; set; } = null!;

    public string ProcedureName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SRProcedureCategory { get; set; }
}
