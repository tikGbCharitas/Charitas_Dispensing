using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NutritionCareTerminology
{
    public string TerminologyID { get; set; } = null!;

    public string? TerminologyName { get; set; }

    public string? TerminologyDesc { get; set; }

    public string SRNutritionCareTerminologyLevel { get; set; } = null!;

    public string? SequenceNo { get; set; }

    public string? TerminologyParentID { get; set; }

    public int? TerminologyLevel { get; set; }

    public string? DomainID { get; set; }

    public bool? IsDetail { get; set; }

    public string? RespondTemplate { get; set; }

    public bool IsActive { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public virtual ICollection<NutritionCareAssessmentQuestionDiagnose> NutritionCareAssessmentQuestionDiagnoses { get; set; } = new List<NutritionCareAssessmentQuestionDiagnose>();
}
