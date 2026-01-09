using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TNABudget
{
    public string TNABudgetNo { get; set; } = null!;

    public string? TransactionCode { get; set; }

    public string? ReferenceNo { get; set; }

    public string? TNAName { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? TNALocation { get; set; }

    public string? TNAOrganizer { get; set; }

    public string? TNAYear { get; set; }

    public bool? IsInHouseTraining { get; set; }

    public string? Note { get; set; }

    public DateTime? StartDate { get; set; }

    public TimeOnly? StartTime { get; set; }

    public DateTime? EndDate { get; set; }

    public TimeOnly? EndTime { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateUserID { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public string? TNAMatrixID { get; set; }

    public string? SRTNAType { get; set; }

    public decimal? TNAMainCost { get; set; }

    public string? TNAMainCostCurrency { get; set; }

    public decimal? TNAMainCostCurrencyRate { get; set; }

    public bool? IsTransactionLocked { get; set; }

    public decimal? Days { get; set; }

    public decimal? Participants { get; set; }

    public decimal? TotalBudgetPriceRupiah { get; set; }

    public bool? IsOnSite { get; set; }

    public int? BudgetPlanCounter { get; set; }

    public string? PAPPKR { get; set; }

    public string? GeneralPurpose { get; set; }

    public string? SpecificPurpose { get; set; }
}
