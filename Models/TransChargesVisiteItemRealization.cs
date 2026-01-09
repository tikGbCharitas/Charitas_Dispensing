using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesVisiteItemRealization
{
    public string TransactionNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
