using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NutritionCareDiagnoseEvaluation
{
    public long ID { get; set; }

    public long? EvaluationID { get; set; }

    public long? InterventionID { get; set; }

    public string? NutritionCareInterventionID { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }
}
