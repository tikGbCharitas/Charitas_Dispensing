using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class OtherBudget
{
    public string OtherBudgetNo { get; set; } = null!;

    public string? ServiceUnitId { get; set; }

    public string? Year { get; set; }

    public string? Note { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public string? ReferenceNo { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateUserID { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? TransactionCode { get; set; }

    public int? BudgetPlanCounter { get; set; }
}
