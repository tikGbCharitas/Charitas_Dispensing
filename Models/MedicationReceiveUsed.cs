using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicationReceiveUsed
{
    public long MedicationReceiveNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? ScheduleDateTime { get; set; }

    public DateTime? SetupDateTime { get; set; }

    public string? SetupByUserID { get; set; }

    public DateTime? VerificationDateTime { get; set; }

    public string? VerificationByUserID { get; set; }

    public DateTime? RealizedDateTime { get; set; }

    public string? RealizedByUserID { get; set; }

    public decimal Qty { get; set; }

    public string? ParamedicID { get; set; }

    public string? SRMedicationReason { get; set; }

    public bool? IsNotConsume { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public bool? IsReSchedule { get; set; }

    public bool? IsVoidSchedule { get; set; }

    public bool? IsAdditionalSchedule { get; set; }
}
