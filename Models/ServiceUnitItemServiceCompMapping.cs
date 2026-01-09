using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitItemServiceCompMapping
{
    public string ServiceUnitID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public int? ChartOfAccountIdIncome { get; set; }

    public int? SubledgerIdIncome { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public int? ChartOfAccountIdCost { get; set; }

    public int? SubledgerIdCost { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string SRRegistrationType { get; set; } = null!;

    public string SRRegistrationTypeMergeTo { get; set; } = null!;

    public string SRGuarantorIncomeGroup { get; set; } = null!;

    public string ClassID { get; set; } = null!;
}
