using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AVCScannerRule
{
    public int ScannerRuleID { get; set; }

    public string? TemplateName { get; set; }

    public string? ButtonName { get; set; }

    public string? ButtonDescription { get; set; }

    public string? GroupID { get; set; }

    public bool? SOAP { get; set; }

    public bool? OBAT { get; set; }

    public bool? JO { get; set; }

    public bool? REFER { get; set; }

    public bool? PAYMENT { get; set; }

    public string? GuarantorDetail { get; set; }

    public int? CounterID { get; set; }

    public string? Type { get; set; }

    public int? NextCounterID { get; set; }

    public string? ButtonGroup { get; set; }

    public int? SortButtonGroup { get; set; }

    public string? ButtonIcon { get; set; }

    public string? Notes { get; set; }

    public bool? IsSunday { get; set; }

    public bool? IsTransactionUnit { get; set; }

    public int? urutanRule { get; set; }
}
