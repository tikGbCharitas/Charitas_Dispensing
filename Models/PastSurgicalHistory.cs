using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PastSurgicalHistory
{
    public string PatientID { get; set; } = null!;

    public string? SurgicalHistory { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
