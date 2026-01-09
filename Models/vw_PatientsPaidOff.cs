using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_PatientsPaidOff
{
    public string RegistrationNo { get; set; } = null!;

    public bool? IsPaidOff { get; set; }
}
