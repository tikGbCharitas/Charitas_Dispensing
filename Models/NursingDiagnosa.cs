using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NursingDiagnosa
{
    public string NursingDiagnosaID { get; set; } = null!;

    public string? NursingDiagnosaName { get; set; }

    public string SRNursingDiagnosaLevel { get; set; } = null!;

    public string? SequenceNo { get; set; }

    public bool IsActive { get; set; }

    public string? NursingDiagnosaParentID { get; set; }

    public string? SRNursingNicType { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string? RespondTemplate { get; set; }

    public string? KSK { get; set; }

    public virtual ICollection<NursingAssessmentDiagnosa> NursingAssessmentDiagnosas { get; set; } = new List<NursingAssessmentDiagnosa>();
}
