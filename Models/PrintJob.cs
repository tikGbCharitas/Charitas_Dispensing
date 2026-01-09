using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PrintJob
{
    public long PrintNo { get; set; }

    public DateTime PrintDateTime { get; set; }

    public string ProgramID { get; set; } = null!;

    public string PrinterID { get; set; } = null!;

    public string UserID { get; set; } = null!;

    public string? ZplCommand { get; set; }

    public string? ApplicationID { get; set; }

    public string? UserHostName { get; set; }
}
