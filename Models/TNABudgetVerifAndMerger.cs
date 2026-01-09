using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TNABudgetVerifAndMerger
{
    public string? TNABudgetNo { get; set; }

    public string SequenceNo { get; set; } = null!;

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ReferenceNo { get; set; }
}
