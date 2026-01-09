using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class NursingDiagnosaTransDT
{
    public long ID { get; set; }

    public string TransactionNo { get; set; } = null!;

    public string NursingDiagnosaID { get; set; } = null!;

    public string? NursingDiagnosaName { get; set; }

    public string SRNursingDiagnosaLevel { get; set; } = null!;

    public string? NursingDiagnosaParentID { get; set; }

    public int Priority { get; set; }

    public int Skala { get; set; }

    public int Target { get; set; }

    public string? Respond { get; set; }

    public int Evaluasi { get; set; }

    public bool Reexamine { get; set; }

    public DateTime ExecuteDateTime { get; set; }

    public string CreateByUserID { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string TmpNursingDiagnosaID { get; set; } = null!;

    public string TmpNursingDiagnosaParentID { get; set; } = null!;

    public int? EvalPeriod { get; set; }

    public int? PeriodConversionInHour { get; set; }

    public string? S { get; set; }

    public string? O { get; set; }

    public string? A { get; set; }

    public string? SRNursingCarePlanning { get; set; }

    public string? P { get; set; }

    public long? ParentID { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ReferenceToPhrNo { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDatetime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsPRMRJ { get; set; }

    public string? PpaInstruction { get; set; }

    public string? SRUserType { get; set; }

    public string? PrescriptionCurrentDay { get; set; }

    public string? SubmitBy { get; set; }

    public string? ReceiveBy { get; set; }

    public bool? IsTulbakon { get; set; }

    public string? TulbakonByUserID { get; set; }

    public DateTime? TulbakonDatetime { get; set; }

    public string? Tul { get; set; }

    public string? Ba { get; set; }

    public string? Kon { get; set; }

    public string? InstructionTo { get; set; }

    public string? InstructionBy { get; set; }

    public DateTime? AppointmentDateOfNursingDiagnose { get; set; }

    public string? AppointmentTimeOfNursingDiagnose { get; set; }
}
