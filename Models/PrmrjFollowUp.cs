using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PrmrjFollowUp
{
    public string RegistrationInfoMedicID { get; set; } = null!;

    public string? ImportantClinicalNotes { get; set; }

    public string? Planning { get; set; }

    public string? Remark { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
