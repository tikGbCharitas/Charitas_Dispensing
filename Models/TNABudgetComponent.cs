using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TNABudgetComponent
{
    public string TNABudgetNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string? SRTNAEmployeePosition { get; set; }

    public string? SRTNACostComponent { get; set; }

    public decimal Price { get; set; }

    public string? CurrencyId { get; set; }

    public decimal CurrencyRate { get; set; }

    public decimal Quantity { get; set; }

    public bool? IsMultipleByDay { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ReferenceNo { get; set; }
}
