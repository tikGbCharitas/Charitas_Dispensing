using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientIncidentRelatedUnit
{
    public string PatientIncidentNo { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string? IncidentDirectCause { get; set; }

    public string? IncidentUnderlyingCauses { get; set; }

    public string? InvestigationByUserID { get; set; }

    public DateTime? InvestigationDateTime { get; set; }

    public bool? IsInvestigationApproved { get; set; }

    public string? InvestigationApprovedByUserID { get; set; }

    public DateTime? InvestigationApprovedDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
