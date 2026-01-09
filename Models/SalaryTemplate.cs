using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SalaryTemplate
{
    public int SalaryTemplateID { get; set; }

    public string SalaryTemplateCode { get; set; } = null!;

    public string SalaryTemplateName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
