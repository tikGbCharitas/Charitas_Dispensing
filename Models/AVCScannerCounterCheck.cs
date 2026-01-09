using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AVCScannerCounterCheck
{
    public int? ScannerTemplateID { get; set; }

    public int? ScannerRuleID { get; set; }
}
