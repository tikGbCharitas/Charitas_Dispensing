using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_registrationque
{
    public string? MedicalNo { get; set; }

    public string? PatientName { get; set; }

    public string ParamedicID { get; set; } = null!;

    public string ParamedicName { get; set; } = null!;

    public string ServiceUnitName { get; set; } = null!;

    public string RoomName { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }

    public string RegistrationTime { get; set; } = null!;

    public int? RegistrationQue { get; set; }

    public bool? IsVoid { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string RoomID { get; set; } = null!;
}
