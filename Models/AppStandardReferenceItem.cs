using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppStandardReferenceItem
{
    public string StandardReferenceID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? Note { get; set; }

    public bool? IsUsedBySystem { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ReferenceID { get; set; }

    public int? coaID { get; set; }

    public int? subledgerID { get; set; }

    public int? LineNumber { get; set; }

    public string? CustomField { get; set; }

    public decimal? NumericValue { get; set; }

    public string? CustomField2 { get; set; }
}
