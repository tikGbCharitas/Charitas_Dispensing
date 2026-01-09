using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WorkProgramKPIMasterRelate
{
    public int ID { get; set; }

    public int? WorkProgramKPIMasterServiceUnitID { get; set; }

    public string? WorkProgramNo { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
