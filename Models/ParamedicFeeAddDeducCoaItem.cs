using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeAddDeducCoaItem
{
    public int ListItemId { get; set; }

    public string TransactionNo { get; set; } = null!;

    public int ChartOfAccountId { get; set; }

    public int SubledgerId { get; set; }

    public decimal Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
