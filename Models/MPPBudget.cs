using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MPPBudget
{
    public string MPPBudgetNo { get; set; } = null!;

    public string? TransactionCode { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? MPPYear { get; set; }

    public string? Note { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateUserID { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public bool? IsTransactionLocked { get; set; }

    public string? MPPMatrixID { get; set; }

    public int? BudgetPlanCounter { get; set; }

    public decimal? TotalPrice { get; set; }
}
