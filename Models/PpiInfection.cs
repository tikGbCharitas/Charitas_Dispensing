using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PpiInfection
{
    public string RegistrationNo { get; set; } = null!;

    public string SRInfectionType { get; set; } = null!;

    public short? DaysTo { get; set; }

    public string? Cultures { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
