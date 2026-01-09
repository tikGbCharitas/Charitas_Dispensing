using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CashMutation
{
    public int CashMutationId { get; set; }

    public int TransactionId { get; set; }

    public int? JournalId { get; set; }

    public string? JournalNumber { get; set; }

    public string BankId { get; set; } = null!;

    public int BankChartOfAccountId { get; set; }

    public DateTime TransactionDate { get; set; }

    public string TransactionType { get; set; } = null!;

    public string PaymentType { get; set; } = null!;

    public string PaymentMethod { get; set; } = null!;

    public string NormalBalance { get; set; } = null!;

    public string Module { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal CurrencyRate { get; set; }

    public string ChequeNumber { get; set; } = null!;

    public string DocumentNumber { get; set; } = null!;

    public int DetailId { get; set; }

    public int ChartOfAccountId { get; set; }

    public int SubLedgerId { get; set; }

    public int CostCenterId { get; set; }

    public decimal Amount { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string Description { get; set; } = null!;

    public string? Description_Detail { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public int CashMutationType { get; set; }
}
