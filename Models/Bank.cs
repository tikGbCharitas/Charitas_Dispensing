using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Bank
{
    public string BankID { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? NoRek { get; set; }

    public string? JournalCode { get; set; }

    public string? CurrencyCode { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsToBeCleared { get; set; }

    public bool? IsCrossRefference { get; set; }

    public bool? IsFeePayment { get; set; }

    public virtual ICollection<BankAccountBalance> BankAccountBalances { get; set; } = new List<BankAccountBalance>();

    public virtual ICollection<CashTransaction> CashTransactions { get; set; } = new List<CashTransaction>();
}
