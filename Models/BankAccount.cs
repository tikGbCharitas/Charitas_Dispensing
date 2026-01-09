using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BankAccount
{
    public string BankID { get; set; } = null!;

    public string BankAccountNo { get; set; } = null!;

    public string? SRCurrency { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
