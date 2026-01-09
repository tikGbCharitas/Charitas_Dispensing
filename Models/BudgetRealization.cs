using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BudgetRealization
{
    public string? BudgetRealizationNo { get; set; }

    public string? TransactionCode { get; set; }

    public string? ReferenceTransactionCode { get; set; }

    public string? RequestedReferenceNo { get; set; }

    public string? ApprovedReferenceNo { get; set; }

    public bool? IsApprove { get; set; }

    public bool? IsVoid { get; set; }

    public string? Note { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? LastCreateUserID { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public string? ApprovalByUserID { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? Year { get; set; }

    public string? ReferenceSequenceNo { get; set; }

    public decimal? TotalPrice { get; set; }

    public string? PaidTo { get; set; }

    public string? ReceivedBy { get; set; }

    public string? ProposalID { get; set; }

    public decimal? ProposalBudget { get; set; }
}
