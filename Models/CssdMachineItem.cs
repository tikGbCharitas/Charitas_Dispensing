using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CssdMachineItem
{
    public string MachineID { get; set; } = null!;

    public string SRCssdProcessType { get; set; } = null!;

    public short Duration { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
