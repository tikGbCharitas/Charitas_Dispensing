using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalDischargeSummaryByNurse
{
    public string RegistrationNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? Temp { get; set; }

    public string? Pulse { get; set; }

    public string? Respiratory { get; set; }

    public string? BloodPress { get; set; }

    public string? DietType { get; set; }

    public string? SpecialDietNote { get; set; }

    public string? DietLiquidLimitNote { get; set; }

    public string? DefecateType { get; set; }

    public string? UrinateType { get; set; }

    public DateOnly? CatheterLastDate { get; set; }

    public string? UterineType { get; set; }

    public int? UterineHeight { get; set; }

    public string? VulvaType { get; set; }

    public string? PerinealWoundType { get; set; }

    public string? LocheaType { get; set; }

    public string? LocheaColor { get; set; }

    public string? LocheaSmell { get; set; }

    public string? OperationWoundType { get; set; }

    public string? TransferMobilizationType { get; set; }

    public string? PartiallyAssisted { get; set; }

    public string? AssistToolType { get; set; }

    public string? Education { get; set; }

    public string? EducationOthers { get; set; }

    public string? TreatmentDiag01 { get; set; }

    public string? TreatmentDiag02 { get; set; }

    public string? TreatmentDiag03 { get; set; }

    public string? TreatmentDiag04 { get; set; }

    public string? DischargeDiag01 { get; set; }

    public string? DischargeDiag02 { get; set; }

    public string? DischargeDiag03 { get; set; }

    public string? DischargeDiag04 { get; set; }

    public string? DrugsTaken { get; set; }

    public string? PossibleEffect { get; set; }

    public string? HospitalRefer { get; set; }

    public int? LabResultSheet { get; set; }

    public int? XRaysSheet { get; set; }

    public int? CTScanSheet { get; set; }

    public int? MriMraSheet { get; set; }

    public int? UsgResultSheet { get; set; }

    public bool? IsCertIllnes { get; set; }

    public bool? IsInsLetter { get; set; }

    public bool? IsDischSummaryLetter { get; set; }

    public bool? IsBabyBook { get; set; }

    public bool? IsBabyBloodType { get; set; }

    public bool? IsCertBirth { get; set; }

    public string? HandedBy { get; set; }

    public string? OtherLetter { get; set; }

    public string? ControlPlan { get; set; }
}
