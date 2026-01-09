using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitItemService
{
    public string ServiceUnitID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsAllowEditByUserVerificated { get; set; }

    public bool? IsVisible { get; set; }
}
