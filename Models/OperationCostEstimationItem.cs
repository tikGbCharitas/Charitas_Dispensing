using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class OperationCostEstimationItem
{
    public string DiagnoseID { get; set; } = null!;

    public string ProcedureID { get; set; } = null!;

    public string SRProcedureCategory { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string ItemGroupID { get; set; } = null!;

    public string? ItemGroupName { get; set; }

    public string SRBillingGroup { get; set; } = null!;

    public decimal? CostAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
