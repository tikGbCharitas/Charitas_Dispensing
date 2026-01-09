using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientDischargeHistory
{
    public string RegistrationNo { get; set; } = null!;

    public string BedID { get; set; } = null!;

    public DateTime DischargeDate { get; set; }

    public string DischargeTime { get; set; } = null!;

    public string DischargeOperatorID { get; set; } = null!;

    public bool IsCancel { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
