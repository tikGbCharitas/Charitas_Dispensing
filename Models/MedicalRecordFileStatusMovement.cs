using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalRecordFileStatusMovement
{
    public string RegistrationNo { get; set; } = null!;

    public string LastPositionServiceUnitID { get; set; } = null!;

    public DateTime? LastPositionDateTime { get; set; }

    public string? LastPositionUserID { get; set; }
}
