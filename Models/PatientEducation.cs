using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientEducation
{
    public string RegistrationNo { get; set; } = null!;

    public int SeqNo { get; set; }

    public DateTime? EducationDateTime { get; set; }

    public string? ParamedicID { get; set; }

    public string? SRUserType { get; set; }

    public string? SRPatientEducationProblem { get; set; }

    public string? SRPatientEducationMethod { get; set; }

    public string? MethodOther { get; set; }

    public string? SRPatientEducationRecipient { get; set; }

    public string? RecipientName { get; set; }

    public string? SRPatientEducationEvaluation { get; set; }

    public int? Duration { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
