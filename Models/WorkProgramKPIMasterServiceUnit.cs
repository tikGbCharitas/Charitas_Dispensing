using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WorkProgramKPIMasterServiceUnit
{
    public int ID { get; set; }

    public string? WorkProgramKPIMasterID { get; set; }

    public string? WorkProgramKPIMasterParentID { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? KPIYear { get; set; }

    public bool? IsActive { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
