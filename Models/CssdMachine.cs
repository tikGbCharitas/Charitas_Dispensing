using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CssdMachine
{
    public string MachineID { get; set; } = null!;

    public string MachineName { get; set; } = null!;

    public DateTime StartUsingDate { get; set; }

    public decimal Volume { get; set; }

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
