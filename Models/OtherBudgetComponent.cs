using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class OtherBudgetComponent
{
    public string? OtherBudgetNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? SROtherBudget { get; set; }

    public decimal? Price { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ReferenceNo { get; set; }

    public string? PAPPKR { get; set; }

    public string? Note { get; set; }
}
