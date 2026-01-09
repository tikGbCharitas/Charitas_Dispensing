using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonnelRequisition
{
    public int PersonnelRequisitionID { get; set; }

    public int RequestedByPersonID { get; set; }

    public int NumberOfRequiredEmployee { get; set; }

    public string SRRequestStatus { get; set; } = null!;

    public int RecruitmentPlanID { get; set; }

    public int OrganizationUnitID { get; set; }

    public string SRPreferredSource { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string? Reason { get; set; }

    public string? MiscellaneousSpec { get; set; }

    public string SREmploymentType { get; set; } = null!;

    public int? ProbationMonth { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
