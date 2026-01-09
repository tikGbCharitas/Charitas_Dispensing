using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ChartOfAccount
{
    public int ChartOfAccountId { get; set; }

    public string ChartOfAccountCode { get; set; } = null!;

    public string ChartOfAccountName { get; set; } = null!;

    public bool IsDetail { get; set; }

    public int AccountLevel { get; set; }

    public string? GeneralAccount { get; set; }

    public string NormalBalance { get; set; } = null!;

    public int AccountGroup { get; set; }

    public int? SubLedgerId { get; set; }

    public bool IsDocumenNumberEnabled { get; set; }

    public string? TreeCode { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string LastUpdateByUserID { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool isControlDocNumber { get; set; }

    public string? Note { get; set; }

    public bool? IsReconcile { get; set; }

    public int? BkuAccountID { get; set; }

    public bool? IsAutoCashEntry { get; set; }

    public virtual ICollection<ChartOfAccountBalance> ChartOfAccountBalances { get; set; } = new List<ChartOfAccountBalance>();

    public virtual ICollection<JournalTransactionDetail> JournalTransactionDetails { get; set; } = new List<JournalTransactionDetail>();

    public virtual ICollection<SubLedgerBalance> SubLedgerBalances { get; set; } = new List<SubLedgerBalance>();
}
