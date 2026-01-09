using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NutritionCareTerminologyTemplate
{
    public int TemplateID { get; set; }

    public string TemplateName { get; set; } = null!;

    public string TemplateText { get; set; } = null!;

    public bool IsActive { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
