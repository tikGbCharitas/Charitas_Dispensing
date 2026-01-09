using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeePerformance
{
    public int EmployeePerformanceID { get; set; }

    public int PersonID { get; set; }

    public string SREmployeePerformanceType { get; set; } = null!;

    public string PerformanceDescription { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
