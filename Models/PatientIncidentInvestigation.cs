using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientIncidentInvestigation
{
    public string PatientIncidentNo { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string SeqNo { get; set; } = null!;

    public string? Recomendation { get; set; }

    public DateTime? RecomendationDateTime { get; set; }

    public string? PersonInCharge { get; set; }

    public string? Implementation { get; set; }

    public DateTime? ImplementationDateTime { get; set; }

    public string? FollowUp { get; set; }

    public DateTime? FollowUpDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
