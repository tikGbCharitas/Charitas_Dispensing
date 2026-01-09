using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BudgetRealizationComponent
{
    public string? BudgetRealizationNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? ComponentName { get; set; }

    public decimal? Price { get; set; }

    public string? ReferenceNo { get; set; }

    public string? SRBudgetCode { get; set; }

    public string? BudgetID { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? SRMPPJobPosition { get; set; }

    public string? SRMPPEducation { get; set; }
}
