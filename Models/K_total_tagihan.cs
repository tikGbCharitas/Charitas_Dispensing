using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class K_total_tagihan
{
    public string RegistrationNo { get; set; } = null!;

    public decimal? TotTagihan { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
