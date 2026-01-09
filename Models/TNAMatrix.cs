using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TNAMatrix
{
    public string TNAMatrixID { get; set; } = null!;

    public bool? IsInHouseTraining { get; set; }

    public bool? IsActive { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
