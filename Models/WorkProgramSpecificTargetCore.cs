using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class WorkProgramSpecificTargetCore
{
    public string? WorkProgramNo { get; set; }

    public string? WorkProgramSpecificTargetSqNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? WorkProgramSpecificTargetCoreName { get; set; }

    public string? ControlPoint { get; set; }

    public DateTime? DateLimit { get; set; }

    public string? TimeSchedule { get; set; }

    public string? ResponsibilityPerson { get; set; }

    public bool? PlanMonth01 { get; set; }

    public bool? PlanMonth02 { get; set; }

    public bool? PlanMonth03 { get; set; }

    public bool? PlanMonth04 { get; set; }

    public bool? PlanMonth05 { get; set; }

    public bool? PlanMonth06 { get; set; }

    public bool? PlanMonth07 { get; set; }

    public bool? PlanMonth08 { get; set; }

    public bool? PlanMonth09 { get; set; }

    public bool? PlanMonth10 { get; set; }

    public bool? PlanMonth11 { get; set; }

    public bool? PlanMonth12 { get; set; }

    public string? Note { get; set; }

    public decimal? IndexTargetCore { get; set; }

    public bool? IsCompleteSemester1 { get; set; }

    public bool? IsCompleteSemester2 { get; set; }

    public string? ControlPointPath { get; set; }

    public bool? IsException { get; set; }

    public string? ExceptionNotes { get; set; }

    public string? AssessmentNote { get; set; }
}
