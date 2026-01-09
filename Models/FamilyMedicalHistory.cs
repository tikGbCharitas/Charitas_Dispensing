using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class FamilyMedicalHistory
{
    public string PatientID { get; set; } = null!;

    public string SRMedicalDisease { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
