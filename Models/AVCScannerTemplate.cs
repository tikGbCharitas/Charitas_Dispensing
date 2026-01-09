using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AVCScannerTemplate
{
    public int ScannerTemplateID { get; set; }

    public string? ScannerTemplateName { get; set; }

    public string? ScannerTemplateDescription { get; set; }
}
