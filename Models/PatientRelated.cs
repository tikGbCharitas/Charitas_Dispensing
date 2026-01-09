using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientRelated
{
    public string PatientID { get; set; } = null!;

    public string RelatedPatientID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
