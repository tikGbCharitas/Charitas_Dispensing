using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppAutoNumberTransactionCode
{
    public string SRTransactionCode { get; set; } = null!;

    public string SRAutoNumber { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
