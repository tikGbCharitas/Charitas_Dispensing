using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PettyCashItem
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }
}
