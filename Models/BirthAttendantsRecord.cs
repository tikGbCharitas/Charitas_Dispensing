using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BirthAttendantsRecord
{
    public string RegistrationNo { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string? SRMidwivesType { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
