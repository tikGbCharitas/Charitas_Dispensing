using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BudgetDiversion
{
    public string BudgetDiversionNo { get; set; } = null!;

    public string? TransactionCode { get; set; }

    public string? ServiceUnitID { get; set; }

    public DateTime? TransactionDate { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateUserID { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public string? ApprovalByUserID { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Note { get; set; }

    public string? BudgetType { get; set; }

    public string? FromItemID { get; set; }

    public decimal? FromItemQty { get; set; }

    public decimal? FromItemNominal { get; set; }

    public string? FromItemSRItemUnit { get; set; }

    public decimal? FromItemConversionFactor { get; set; }

    public string? ToItemID { get; set; }

    public decimal? ToItemQty { get; set; }

    public decimal? ToItemNominal { get; set; }

    public string? ToItemSRItemUnit { get; set; }

    public decimal? ToItemConversionFactor { get; set; }
}
