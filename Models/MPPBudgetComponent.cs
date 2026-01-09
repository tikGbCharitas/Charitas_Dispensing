using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MPPBudgetComponent
{
    public string? MPPBudgetNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? SRMPPJobPosition { get; set; }

    public string? SRMPPEducation { get; set; }

    public decimal? Price { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ReferenceNo { get; set; }

    public decimal? QtyReplacement { get; set; }

    public decimal? QtyWorkLoadEnhancement { get; set; }

    public decimal? QtyServiceDevelopment { get; set; }

    public decimal? RecruitmentPlanMonth { get; set; }

    public string? PAPPKR { get; set; }

    public decimal? CurrentEmployeeAmount { get; set; }

    public decimal? EmployeeNeedStandardAmount { get; set; }

    public string? RelatedWorkProgramNo { get; set; }

    public string? RelatedWorkProgramSpecificTargetSqNo { get; set; }

    public string? RelatedWorkProgramSpecificTargetCoreSqNo { get; set; }

    public decimal? RelatedQuantity { get; set; }
}
