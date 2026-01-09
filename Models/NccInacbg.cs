using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NccInacbg
{
    public string RegistrationNo { get; set; } = null!;

    public int? PatientId { get; set; }

    public int? AdmissionId { get; set; }

    public int? HospitalAdmissionId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
