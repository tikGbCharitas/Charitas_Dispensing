using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ProposalEmployeeRecruitment
{
    public string ProposalEmployeeRecruitmentID { get; set; } = null!;

    public string? ServiceUnitID { get; set; }

    public string? ProposalYear { get; set; }

    public string? SREmployeeDepartment { get; set; }

    public string? SREmployeeJobPosition { get; set; }

    public string? SREmployeeJobEducation { get; set; }

    public string? SRRecruitmentReason { get; set; }

    public bool? RequestIsToFillStandardAmount { get; set; }

    public bool? RequestIsToCentralizedActivity { get; set; }

    public bool? RequestIsOther { get; set; }

    public string? RequestIsOtherNote { get; set; }

    public int? AmountOfStoppedEmployee { get; set; }

    public int? AmountOfRequestedEmployee { get; set; }

    public DateTime? NeededDate { get; set; }

    public string? EmployeeStatus { get; set; }

    public string? ResponsilibityTo { get; set; }

    public string? RequiredWorkExperience { get; set; }

    public string? RequiredCertificate { get; set; }

    public string? RequiredSkill { get; set; }

    public string? MainJob { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public string? ApprovalByUserID { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public bool? Phase1IsApprove { get; set; }

    public string? Phase1ApprovedByUserID { get; set; }

    public DateTime? Phase1LastUpdateDateTime { get; set; }

    public bool? Phase1IsAccordingToTheNeeds { get; set; }

    public int? Phase1ApprovedQuantity { get; set; }

    public string? Phase1EmployeeStatus { get; set; }

    public bool? Phase1IsMutationFromUnit { get; set; }

    public decimal? Phase1IsMutationFromUnitQty { get; set; }

    public string? Phase1IsMutationFromUnitNote { get; set; }

    public bool? Phase1IsAssignmentFromunit { get; set; }

    public decimal? Phase1IsAssignmentFromunitQty { get; set; }

    public string? Phase1IsAssignmentFromunitNote { get; set; }

    public bool? Phase1IsNewRecruitment { get; set; }

    public decimal? Phase1IsNewRecruitmentQty { get; set; }

    public string? Phase1IsNewRecruitmentNote { get; set; }

    public string? Phase1Notes { get; set; }

    public bool? Phase2IsApprove { get; set; }

    public string? Phase2ApprovedByUserID { get; set; }

    public DateTime? Phase2LastUpdateDateTime { get; set; }

    public string? Phase2EmployeeStatus { get; set; }

    public bool? Phase2IsMutationFromUnit { get; set; }

    public decimal? Phase2IsMutationFromUnitQty { get; set; }

    public string? Phase2IsMutationFromUnitNote { get; set; }

    public bool? Phase2IsAssignmentFromunit { get; set; }

    public decimal? Phase2IsAssignmentFromunitQty { get; set; }

    public string? Phase2IsAssignmentFromunitNote { get; set; }

    public bool? Phase2IsNewRecruitment { get; set; }

    public decimal? Phase2IsNewRecruitmentQty { get; set; }

    public string? Phase2IsNewRecruitmentNote { get; set; }

    public string? Phase2Notes { get; set; }

    public string? Phase1ApprovalStatus { get; set; }

    public string? Phase2ApprovalStatus { get; set; }
}
