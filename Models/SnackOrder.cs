using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SnackOrder
{
    public string SnackOrderNo { get; set; } = null!;

    public DateTime SnackOrderDate { get; set; }

    public DateTime SnackOrderForDate { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserID { get; set; }
}
