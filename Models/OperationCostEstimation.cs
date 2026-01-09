using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class OperationCostEstimation
{
    public string DiagnoseID { get; set; } = null!;

    public string ProcedureID { get; set; } = null!;

    public string SRProcedureCategory { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public decimal? CostAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
