using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NursingDiagnosaEvaluation
{
    public long ID { get; set; }

    public long? EvaluationID { get; set; }

    public long? InterventionID { get; set; }

    public string? NursingInterventionID { get; set; }

    public string? SRNursingCarePlanning { get; set; }

    public string? CreateByUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }
}
