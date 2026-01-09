using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationCoverageDetail
{
    public string RegistrationNo { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public decimal CoverageAmount { get; set; }

    public decimal? CalculatedAmount { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateUserID { get; set; }
}
