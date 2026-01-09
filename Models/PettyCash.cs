using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PettyCash
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string SRPettyCashUnitID { get; set; } = null!;

    public string? BankID { get; set; }

    public string Notes { get; set; } = null!;

    public decimal? TotalDebitAmount { get; set; }

    public decimal? TotalCreditAmount { get; set; }

    public string? ReferenceNo { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
