using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WaOutbox
{
    public long waoutboxID { get; set; }

    public string? phoneno { get; set; }

    public string? messagetext { get; set; }

    public int? status { get; set; }

    public string? media { get; set; }

    public string? PatientID { get; set; }

    public string? createby { get; set; }

    public DateTime? createdate { get; set; }

    public DateTime? senddate { get; set; }
}
