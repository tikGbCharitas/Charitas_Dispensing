using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class QuestionForm
{
    public string QuestionFormID { get; set; } = null!;

    public string QuestionFormName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool? IsMCUForm { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ReportProgramID { get; set; }

    public bool IsAskepForm { get; set; }

    public bool? IsVSignForm { get; set; }

    public bool? IsSingleEntry { get; set; }

    public string? RmNO { get; set; }

    public bool? IsInitialAssessment { get; set; }

    public bool? IsContinuedAssessment { get; set; }

    public bool? IsServiceUnitBookingForm { get; set; }

    public bool? IsGeneralForm { get; set; }

    public bool IsNutritionCareForm { get; set; }

    public bool? IsSoapForm { get; set; }

    public string? SRQuestionFormType { get; set; }

    public string? SRNsType { get; set; }

    public string? RestrictionUserType { get; set; }

    public bool? IsSharingEdit { get; set; }

    public bool? IsUsingApproval { get; set; }
}
