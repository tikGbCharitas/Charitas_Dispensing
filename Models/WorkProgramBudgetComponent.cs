using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WorkProgramBudgetComponent
{
    public string? WorkProgramNo { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceName { get; set; }

    public string? ReferenceTransactionCode { get; set; }

    public string? ParentReferenceNo { get; set; }

    public string? WorkProgramSpecificTargetSqNo { get; set; }

    public string? WorkProgramSpecificTargetCoreSqNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? BudgetType { get; set; }

    public string? BudgetID { get; set; }

    public decimal? Quantity { get; set; }

    public string? SRItemUnit { get; set; }

    public decimal? ConversionFactor { get; set; }

    public decimal? Price { get; set; }
}
