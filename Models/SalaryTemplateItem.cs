using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SalaryTemplateItem
{
    public int SalaryTemplateID { get; set; }

    public int SalaryComponentID { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
