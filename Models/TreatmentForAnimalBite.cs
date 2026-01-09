using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TreatmentForAnimalBite
{
    public string RegistrationNo { get; set; } = null!;

    public string SRTreatmentForAnimalBites { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
