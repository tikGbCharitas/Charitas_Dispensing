using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class JournalTransaction
{
    public int JournalId { get; set; }

    public string JournalCode { get; set; } = null!;

    public string JournalType { get; set; } = null!;

    public string TransactionNumber { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string Description { get; set; } = null!;

    public bool IsPosted { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string LastUpdateByUserID { get; set; } = null!;

    public bool IsVoid { get; set; }

    public DateTime VoidDate { get; set; }

    public string? RefferenceNumber { get; set; }

    public int? JournalIdRefference { get; set; }

    public string? BudgetingCode { get; set; }

    public bool? IsAutoCashEntry { get; set; }

    public string? BankId { get; set; }

    public virtual JournalMessage? JournalMessage { get; set; }

    public virtual ICollection<JournalTransactionDetail> JournalTransactionDetails { get; set; } = new List<JournalTransactionDetail>();
}
