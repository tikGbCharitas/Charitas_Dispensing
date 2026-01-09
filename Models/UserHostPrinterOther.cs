using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class UserHostPrinterOther
{
    public string UserHostName { get; set; } = null!;

    public string ProgramID { get; set; } = null!;

    public string PrinterID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
