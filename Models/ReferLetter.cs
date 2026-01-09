using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ReferLetter
{
    public string RegApptNo { get; set; } = null!;

    public string FromRegistrationNo { get; set; } = null!;

    public string? ActionExamTreatment { get; set; }

    public string? Notes { get; set; }

    public string? Answer { get; set; }

    public bool? IsAppointment { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
