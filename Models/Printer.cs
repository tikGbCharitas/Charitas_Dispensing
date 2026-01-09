using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Printer
{
    public string PrinterID { get; set; } = null!;

    public string PrinterName { get; set; } = null!;

    public string? PrinterLocationHost { get; set; }

    public string? PrinterManagerHost { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
