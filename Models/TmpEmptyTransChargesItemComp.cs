using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TmpEmptyTransChargesItemComp
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string? ItemID { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? ClassID { get; set; }

    public string? ParamedicCollectionName { get; set; }

    public decimal? DiscountAmt { get; set; }

    public decimal? PriceAmt { get; set; }
}
