using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WorkProgramKPIMaster
{
    public string WorkProgramKPIMasterID { get; set; } = null!;

    public string? WorkProgramKPIMasterCode { get; set; }

    public string? WorkProgramKPIMasterName { get; set; }

    public int? KPILevel { get; set; }

    public bool? IsActive { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
