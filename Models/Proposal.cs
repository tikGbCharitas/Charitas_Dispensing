using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Proposal
{
    public string ProposalID { get; set; } = null!;

    public string? ProposalType { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? BudgetPeriode { get; set; }

    public string? Title { get; set; }

    public string? Introduction { get; set; }

    public string? GeneralObjective { get; set; }

    public string? SpecificObjective { get; set; }

    public string? Benefit { get; set; }

    public string? ParticipantsTarget { get; set; }

    public string? Speaker { get; set; }

    public string? FormOfActivity { get; set; }

    public string? ImplementationOfActivity { get; set; }

    public string? ScopeOfMaterials { get; set; }

    public string? Closing { get; set; }

    public bool? IsApprove { get; set; }

    public string? ApprovalByUserID { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public bool? IsVoid { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? VerifiedPhase1Status { get; set; }

    public bool? IsVerifiedPhase1 { get; set; }

    public DateTime? VerifiedPhase1DateTime { get; set; }

    public string? VerifiedPhase1ByUserID { get; set; }

    public string? VerifiedPhase2Status { get; set; }

    public bool? IsVerifiedPhase2 { get; set; }

    public DateTime? VerifiedPhase2DateTime { get; set; }

    public string? VerifiedPhase2ByUserID { get; set; }

    public string? BudgetReferenceNo { get; set; }

    public decimal? BudgetReferenceNominal { get; set; }

    public decimal? BudgetReferenceUsedNominal { get; set; }

    public decimal? BudgetReferenceAvailableNominal { get; set; }
}
