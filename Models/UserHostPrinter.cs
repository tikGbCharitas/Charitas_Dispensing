using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class UserHostPrinter
{
    public string UserHostName { get; set; } = null!;

    public string PrinterID { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
