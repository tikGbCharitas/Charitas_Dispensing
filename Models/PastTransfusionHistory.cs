using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PastTransfusionHistory
{
    public string PatientID { get; set; } = null!;

    public string? Year { get; set; }

    public string? AllergicReaction { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
