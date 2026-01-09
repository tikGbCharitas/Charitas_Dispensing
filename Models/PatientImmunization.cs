using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientImmunization
{
    public string PatientID { get; set; } = null!;

    public string ImmunizationID { get; set; } = null!;

    public int ImmunizationNo { get; set; }

    public DateTime? ImmunizationDate { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceItemID { get; set; }

    public string? VaccineID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsDateInMonthYear { get; set; }
}
