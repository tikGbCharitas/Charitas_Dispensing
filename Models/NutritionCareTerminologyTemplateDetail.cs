using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NutritionCareTerminologyTemplateDetail
{
    public int TemplateID { get; set; }

    public string QuestionID { get; set; } = null!;

    public string CreateByUserID { get; set; } = null!;

    public DateTime? CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }
}
