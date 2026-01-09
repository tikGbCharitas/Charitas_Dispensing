using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SupplierBank
{
    public string SupplierID { get; set; } = null!;

    public string BankAccountNo { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string? BankAccountName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
