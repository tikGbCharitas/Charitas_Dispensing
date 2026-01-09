using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeTrainingHistory
{
    public int EmployeeTrainingHistoryID { get; set; }

    public int PersonID { get; set; }

    public string EventName { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? TrainingLocation { get; set; }

    public string? TrainingInstitution { get; set; }

    public decimal? Fee { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public bool? IsAttending { get; set; }

    public int? EmployeeTrainingID { get; set; }

    public decimal? SponsorFee { get; set; }

    public DateTime? CertLastUpdateTime { get; set; }

    public string? CertificateNo { get; set; }

    public string? CertificatePath { get; set; }

    public string? CertLastUpdateBy { get; set; }

    public decimal? CertCreditPoint { get; set; }

    public string? SRTrainingType { get; set; }

    public int? TotalHour { get; set; }
}
