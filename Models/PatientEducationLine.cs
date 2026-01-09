using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientEducationLine
{
    public string RegistrationNo { get; set; } = null!;

    public int SeqNo { get; set; }

    public string SRPatientEducation { get; set; } = null!;

    public string? EducationNotes { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
