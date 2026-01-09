using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeTraining
{
    public int EmployeeTrainingID { get; set; }

    public string EmployeeTrainingName { get; set; } = null!;

    public string TrainingLocation { get; set; } = null!;

    public string TrainingOrganizer { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public int TotalHour { get; set; }

    public bool IsInHouseTraining { get; set; }

    public decimal CreditPoint { get; set; }

    public decimal TrainingFee { get; set; }

    public decimal? SponsorFee { get; set; }

    public bool IsScheduledTraining { get; set; }

    public int TargetAttendance { get; set; }

    public string Note { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime? CertDateFrom { get; set; }

    public DateTime? CertDateTo { get; set; }

    public string? SRTrainingType { get; set; }
}
