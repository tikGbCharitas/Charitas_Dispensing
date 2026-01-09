using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MPPMatrixComponent
{
    public int MPPMatrixComponentID { get; set; }

    public string? MPPMatrixID { get; set; }

    public string? SRMPPJobPosition { get; set; }

    public string? SRMPPEducation { get; set; }

    public decimal Price { get; set; }
}
