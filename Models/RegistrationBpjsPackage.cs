using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationBpjsPackage
{
    public string RegistrationNo { get; set; } = null!;

    public string PackageID { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
