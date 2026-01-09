using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientImmunizationOther
{
    public string PatientID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? Imunization { get; set; }
}
