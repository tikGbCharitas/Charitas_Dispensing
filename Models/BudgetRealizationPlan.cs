using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BudgetRealizationPlan
{
    public string BudgetRealizationPlanNo { get; set; } = null!;

    public string? TransactionCode { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? Year { get; set; }

    public string? Month { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? ApprovalBy { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidBy { get; set; }

    public bool? IsApprove { get; set; }

    public bool? IsVoid { get; set; }

    public string? Note { get; set; }

    public int? BudgetCounter { get; set; }
}
