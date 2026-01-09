using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationCounselingLine
{
    public string RegistrationNo { get; set; } = null!;

    public int CounselingNo { get; set; }

    public string SRDrugCounseling { get; set; } = null!;

    public string? Notes { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
