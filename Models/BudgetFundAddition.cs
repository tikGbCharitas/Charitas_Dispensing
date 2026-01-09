using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BudgetFundAddition
{
    public string BudgetFundAdditionNo { get; set; } = null!;

    public string? TransactionCode { get; set; }

    public string? BudgetType { get; set; }

    public string? BudgetReferencID { get; set; }

    public decimal? Nominal { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public string? Note { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateUserID { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Year { get; set; }

    public decimal? InitialNominal { get; set; }
}
