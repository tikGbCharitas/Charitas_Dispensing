using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_RegistrationKaryawan
{
    public string RegistrationNo { get; set; } = null!;

    public string FromRegistrationNo { get; set; } = null!;

    public string PatientID { get; set; } = null!;

    public string GuarantorID { get; set; } = null!;

    public string? ParamedicID { get; set; }
}
