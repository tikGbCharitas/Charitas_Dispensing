using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PpiAntimicrobialApplication
{
    public string RegistrationNo { get; set; } = null!;

    public string SRTherapyGroup { get; set; } = null!;

    public string TherapyID { get; set; } = null!;

    public decimal? Dosage { get; set; }

    public string? SRDosageUnit { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? SRAntimicrobialApplicationTiming { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
