using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_ClosedRegistration
{
    public string RegistrationNo { get; set; } = null!;

    public string? ServiceUnitID { get; set; }

    public string? ParamedicID { get; set; }

    public string PatientID { get; set; } = null!;

    public string? RoomID { get; set; }

    public string? BedID { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string ParamedicIDReferral { get; set; } = null!;
}
