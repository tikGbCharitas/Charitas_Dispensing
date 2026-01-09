using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ProposalBudget
{
    public int SequenceNo { get; set; }

    public string ProposalID { get; set; } = null!;

    public string? BudgetDescription { get; set; }

    public string? BudgetNotes { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Days { get; set; }

    public string? ItemUnit { get; set; }

    public decimal? Price { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
