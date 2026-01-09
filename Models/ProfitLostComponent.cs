using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ProfitLostComponent
{
    public string ProfitLostComponentNo { get; set; } = null!;

    public string? Year { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateUserID { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public string? Note { get; set; }
}
