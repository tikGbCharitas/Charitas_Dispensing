using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Overtime
{
    public int OvertimeID { get; set; }

    public string OvertimeName { get; set; } = null!;

    public int SalaryComponentID { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
