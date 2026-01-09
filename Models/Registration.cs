using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Registration
{
    public string RegistrationNo { get; set; } = null!;

    public string? SRRegistrationType { get; set; }

    public string? ParamedicID { get; set; }

    public string GuarantorID { get; set; } = null!;

    public string PatientID { get; set; } = null!;

    public string? ClassID { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string RegistrationTime { get; set; } = null!;

    public string? AppointmentNo { get; set; }

    public byte AgeInYear { get; set; }

    public byte AgeInMonth { get; set; }

    public byte AgeInDay { get; set; }

    public string? SRShift { get; set; }

    public string? SRPatientInType { get; set; }

    public string? InsuranceID { get; set; }

    public string? SRPatientCategory { get; set; }

    public string? SRERCaseType { get; set; }

    public string? SRVisitReason { get; set; }

    public string? SRBussinesMethod { get; set; }

    public decimal? PlavonAmount { get; set; }

    public string? DepartmentID { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? RoomID { get; set; }

    public string? BedID { get; set; }

    public string? ChargeClassID { get; set; }

    public string? CoverageClassID { get; set; }

    public string? VisitTypeID { get; set; }

    public string? ReferralID { get; set; }

    public string? Anamnesis { get; set; }

    public string? Complaint { get; set; }

    public string? InitialDiagnose { get; set; }

    public string? MedicationPlanning { get; set; }

    public string? SRTriage { get; set; }

    public bool IsPrintingPatientCard { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string? DischargeTime { get; set; }

    public string? DischargeMedicalNotes { get; set; }

    public string? DischargeNotes { get; set; }

    public string? SRDischargeCondition { get; set; }

    public string? SRDischargeMethod { get; set; }

    public byte LOSInYear { get; set; }

    public byte LOSInMonth { get; set; }

    public byte LOSInDay { get; set; }

    public string? DischargeOperatorID { get; set; }

    public string AccountNo { get; set; } = null!;

    public decimal TransactionAmount { get; set; }

    public decimal AdministrationAmount { get; set; }

    public decimal RoundingAmount { get; set; }

    public decimal RemainingAmount { get; set; }

    public bool IsTransferedToInpatient { get; set; }

    public bool IsNewPatient { get; set; }

    public bool IsNewBornInfant { get; set; }

    public bool IsParturition { get; set; }

    public bool IsHoldTransactionEntry { get; set; }

    public bool IsHasCorrection { get; set; }

    public bool? IsEMRValid { get; set; }

    public bool? IsBackDate { get; set; }

    public DateTime? ActualVisitDate { get; set; }

    public bool? IsVoid { get; set; }

    public string? SRVoidReason { get; set; }

    public string? VoidNotes { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserID { get; set; }

    public bool? IsClosed { get; set; }

    public bool? IsEpisodeComplete { get; set; }

    public bool? IsClusterAssessment { get; set; }

    public bool? IsConsul { get; set; }

    public bool? IsFromDispensary { get; set; }

    public bool? IsNewVisit { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool isDirectPrescriptionReturn { get; set; }

    public int? RegistrationQue { get; set; }

    public string? VisiteRegistrationNo { get; set; }

    public bool IsGenerateHL7 { get; set; }

    public string? ReferralName { get; set; }

    public bool? IsObservation { get; set; }

    public string? CauseOfAccident { get; set; }

    public string? ReferTo { get; set; }

    public bool? IsOldCase { get; set; }

    public bool? IsDHF { get; set; }

    public bool? IsEKG { get; set; }

    public string? EmrDiagnoseID { get; set; }

    public bool? IsGlobalPlafond { get; set; }

    public DateTime? FirstResponDate { get; set; }

    public string? FirstResponTime { get; set; }

    public DateTime? PhysicianResponDate { get; set; }

    public string? PhysicianResponTime { get; set; }

    public bool? IsRoomIn { get; set; }

    public bool? IsLockVerifiedBilling { get; set; }

    public DateTime? LockVerifiedBillingDateTime { get; set; }

    public string? LockVerifiedBillingByUserID { get; set; }

    public string? ProcedureChargeClassID { get; set; }

    public int? PersonID { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? SREmployeeRelationship { get; set; }

    public string? GuarantorCardNo { get; set; }

    public DateTime? DischargePlanDate { get; set; }

    public string? UsertInsertDischargePlan { get; set; }

    public bool? IsNonPatient { get; set; }

    public string? ReasonsForTreatmentID { get; set; }

    public string? SmfID { get; set; }

    public decimal? PatientAdm { get; set; }

    public decimal? GuarantorAdm { get; set; }

    public string? ReasonsForTreatmentDescID { get; set; }

    public string? SRReferralGroup { get; set; }

    public string? SRDiscountReason { get; set; }

    public string? PhysicianSenders { get; set; }

    public decimal? DiscAdmPatient { get; set; }

    public decimal? DiscAdmGuarantor { get; set; }

    public string? SRPatientInCondition { get; set; }

    public string? SRKiaCaseType { get; set; }

    public string? SRObstetricType { get; set; }

    public string? IsHoldTransactionEntryByUserID { get; set; }

    public string? FromRegistrationNo { get; set; }

    public bool? IsConfirmedAttendance { get; set; }

    public string? ConfirmedAttendanceByUserID { get; set; }

    public DateTime? ConfirmedAttendanceDateTime { get; set; }

    public string? BpjsSepNo { get; set; }

    public decimal? PlavonAmount2 { get; set; }

    public string? DeathCertificateNo { get; set; }

    public decimal? BpjsCoverageFormula { get; set; }

    public string? BpjsPackageID { get; set; }

    public decimal? ApproximatePlafondAmount { get; set; }

    public DateTime? SentToBillingDateTime { get; set; }

    public string? SentToBillingByUserID { get; set; }

    public bool? IsAdjusted { get; set; }

    public string? AdjustLog { get; set; }

    public string? ConfirmPhone { get; set; }

    public string? SRMaritalStatus { get; set; }

    public string? SROccupation { get; set; }

    public string? SRRelationshipQuality { get; set; }

    public string? SRResidentialHome { get; set; }

    public bool? IsPregnant { get; set; }

    public short? GestationalAge { get; set; }

    public bool? IsBreastFeeding { get; set; }

    public short? AgeOfBabyInYear { get; set; }

    public short? AgeOfBabyInMonth { get; set; }

    public short? AgeOfBabyInDay { get; set; }

    public string? SRPlafonOption { get; set; }

    public string? SRDiscountReasonGroup { get; set; }

    public int? nourutlama { get; set; }

    public string? nourut { get; set; }

    public string? no_ref { get; set; }

    public DateTime? DischargePlanningDate { get; set; }

    public string? SRServiceType { get; set; }

    public string? SRMemberChr { get; set; }

    public string? SRRegistrationMedia { get; set; }

    public string? SRServiceMethod { get; set; }

    public bool? MemberVIP { get; set; }

    public string? KdSpesialis { get; set; }

    public string? KdSubSpesialis { get; set; }

    public string? KdSubSpesialis1 { get; set; }

    public string? KdSpesialisSarana { get; set; }

    public string? KdSpesialisKhusus { get; set; }

    public string? NotesKhusus { get; set; }

    public DateTime? VisitEstimatedDate { get; set; }

    public string? KdProvider { get; set; }

    public string? KdTacc { get; set; }

    public string? AlasanTacc { get; set; }

    public string? EncounterID { get; set; }

    public string? DiagnosisID { get; set; }

    public virtual EmergencyContact? EmergencyContact { get; set; }

    public virtual ICollection<EpisodeBodyDiagram> EpisodeBodyDiagrams { get; set; } = new List<EpisodeBodyDiagram>();

    public virtual ICollection<EpisodeDiagnose> EpisodeDiagnoses { get; set; } = new List<EpisodeDiagnose>();

    public virtual ICollection<EpisodeProcedure> EpisodeProcedures { get; set; } = new List<EpisodeProcedure>();

    public virtual ICollection<EpisodeSOAPE> EpisodeSOAPEs { get; set; } = new List<EpisodeSOAPE>();

    public virtual MergeBilling? MergeBilling { get; set; }

    public virtual ICollection<PatientTransfer> PatientTransfers { get; set; } = new List<PatientTransfer>();

    public virtual ICollection<RegistrationDocumentCheckList> RegistrationDocumentCheckLists { get; set; } = new List<RegistrationDocumentCheckList>();

    public virtual ICollection<RegistrationInfoMedical> RegistrationInfoMedicals { get; set; } = new List<RegistrationInfoMedical>();

    public virtual ICollection<RegistrationInfoMedic> RegistrationInfoMedics { get; set; } = new List<RegistrationInfoMedic>();

    public virtual ICollection<RegistrationInfo> RegistrationInfos { get; set; } = new List<RegistrationInfo>();

    public virtual ICollection<RegistrationItemRule> RegistrationItemRules { get; set; } = new List<RegistrationItemRule>();

    public virtual ICollection<ServiceUnitQue> ServiceUnitQues { get; set; } = new List<ServiceUnitQue>();

    public virtual ICollection<TransCharge> TransCharges { get; set; } = new List<TransCharge>();

    public virtual ICollection<TransPayment> TransPayments { get; set; } = new List<TransPayment>();
}
