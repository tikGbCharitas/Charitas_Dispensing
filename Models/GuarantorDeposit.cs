using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class GuarantorDeposit
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string GuarantorID { get; set; } = null!;

    public string? SRPaymentType { get; set; }

    public string? SRPaymentMethod { get; set; }

    public string? SRCardProvider { get; set; }

    public string? SRCardType { get; set; }

    public string? EDCMachineID { get; set; }

    public string? CardHolderName { get; set; }

    public string? BankID { get; set; }

    public string? BankAccountNo { get; set; }

    public decimal? Amount { get; set; }

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
