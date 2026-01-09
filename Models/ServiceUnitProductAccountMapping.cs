using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitProductAccountMapping
{
    public string LocationId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string ProductAccountId { get; set; } = null!;

    public string SRRegistrationType { get; set; } = null!;

    public int? ChartOfAccountIdIncome { get; set; }

    public int? SubledgerIdIncome { get; set; }

    public int? ChartOfAccountIdAccrual { get; set; }

    public int? SubledgerIdAccrual { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public int? ChartOfAccountIdInventory { get; set; }

    public int? SubledgerIdInventory { get; set; }

    public int? ChartOfAccountIdCOGS { get; set; }

    public int? SubledgerIdCOGS { get; set; }

    public int? ChartOfAccountIdExpense { get; set; }

    public int? SubledgerIdExpense { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
