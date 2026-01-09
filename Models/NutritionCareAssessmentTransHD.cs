using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NutritionCareAssessmentTransHD
{
    public long ID { get; set; }

    public string TransactionNo { get; set; } = null!;

    public DateTime AssessmentDateTime { get; set; }

    public string? QuestionFormReference { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
