using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CashTransaction
{
    public int TransactionId { get; set; }

    public int PostingId { get; set; }

    public string BankId { get; set; } = null!;

    public int ChartOfAccountId { get; set; }

    public DateTime TransactionDate { get; set; }

    public string TransactionType { get; set; } = null!;

    public string PaymentType { get; set; } = null!;

    public string PaymentMethod { get; set; } = null!;

    public string NormalBalance { get; set; } = null!;

    public string Module { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal CurrencyRate { get; set; }

    public bool IsPosted { get; set; }

    public bool IsCleared { get; set; }

    public bool IsVoid { get; set; }

    public string ChequeNumber { get; set; } = null!;

    public string DocumentNumber { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int JournalId { get; set; }

    public DateTime VoidDate { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string LastUpdateByUserID { get; set; } = null!;

    public string? JournalNumber { get; set; }

    public DateTime? ClearedDateTime { get; set; }

    public string? ClearedBy { get; set; }

    public int? DetailIdRef { get; set; }

    public DateTime? DueDate { get; set; }

    public string? BudgetingCode { get; set; }

    public bool? IsAutoCashEntry { get; set; }

    public string? ReceivedFromOrPaidTo { get; set; }

    public int? BkuAccountID { get; set; }

    public int? JournalIdAutoCashEntry { get; set; }

    public virtual Bank Bank { get; set; } = null!;

    public virtual ICollection<CashTransactionBalance> CashTransactionBalances { get; set; } = new List<CashTransactionBalance>();

    public virtual ICollection<CashTransactionDetail> CashTransactionDetails { get; set; } = new List<CashTransactionDetail>();
}
