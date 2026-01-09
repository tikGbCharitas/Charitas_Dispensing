using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CashTransactionList
{
    public string ListId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public string? CashType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
