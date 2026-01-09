using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PathologyAnatomy
{
    public string ResultNo { get; set; } = null!;

    public DateTime ResultDate { get; set; }

    public string? ResultTime { get; set; }

    public string ResultType { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime DateOfCompletion { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string? PhysicianSenders { get; set; }

    public string? PhoneNo { get; set; }

    public string? ParamedicID { get; set; }

    public string? DiagnosisID { get; set; }

    public string? LocationID { get; set; }

    public string? MorphologyID { get; set; }

    public string? SourceOfTissueID { get; set; }

    public string? TissueID { get; set; }

    public bool? IsMarried { get; set; }

    public short? NumberOfChildren { get; set; }

    public string? Macroscopic { get; set; }

    public string? Microscopic { get; set; }

    public string? Impression { get; set; }

    public string? ImpressionGroupID { get; set; }

    public string? ImpressionGroupItemID { get; set; }

    public string? AdditionalNotes { get; set; }

    public bool? IsEligibleAdequacyOfTheSpecimen { get; set; }

    public bool? IsTrichomonasVaginalisInfection { get; set; }

    public bool? IsCandidaMoniliaInfection { get; set; }

    public bool? IsCoccobacillusGardnerellaInfection { get; set; }

    public bool? IsActinomycesInfection { get; set; }

    public bool? IsHpvInfection { get; set; }

    public bool? IsHsv2Infection { get; set; }

    public bool? IsOtherInfections { get; set; }

    public string? OtherInfectionsDescription { get; set; }

    public bool? IsInflammatoryReaction { get; set; }

    public bool? IsRepair { get; set; }

    public bool? IsRadiation { get; set; }

    public bool? IsAtrophy { get; set; }

    public string? AtrophyDescription { get; set; }

    public bool? IsFollicularCervicitis { get; set; }

    public bool? IsChemotherapyEffects { get; set; }

    public bool? IsHormonalEffects { get; set; }

    public bool? IsIudEffects { get; set; }

    public bool? IsAsc { get; set; }

    public bool? IsAscUs { get; set; }

    public bool? IsAscH { get; set; }

    public bool? IsSquamousIntraepithelialLesion { get; set; }

    public bool? IsLsil { get; set; }

    public bool? IsLsilHpv { get; set; }

    public bool? IsLsilCin1 { get; set; }

    public bool? IsHsil { get; set; }

    public bool? IsHsilCin2 { get; set; }

    public bool? IsHsilCin3 { get; set; }

    public bool? IsHsilCis { get; set; }

    public bool? IsSquamousCellCarcinoma { get; set; }

    public bool? IsKeratinizing { get; set; }

    public bool? IsNonKeratinizing { get; set; }

    public bool? IsAgc { get; set; }

    public bool? IsAtypicalNos { get; set; }

    public bool? IsAtypicalFavorNeoplastic { get; set; }

    public bool? IsAis { get; set; }

    public bool? IsAdenocarcinoma { get; set; }

    public bool? IsEndoCervical { get; set; }

    public bool? IsEndometrial { get; set; }

    public bool? IsEndometrialCells { get; set; }

    public string? NonEpithelialMalignancies { get; set; }

    public bool? IsHormonalPatternsAccordingToAgeAndHistory { get; set; }

    public bool? IsHormonalPatternDoesNotMatchTheAgeAndHistory { get; set; }

    public bool? IsHormonalEvaluationIsNotPossible { get; set; }

    public string? InterpretationOfResults { get; set; }

    public string? Suggestion { get; set; }

    public bool? IsMammae { get; set; }

    public string? PathologyAnatomyDiagnoses { get; set; }

    public string? Result { get; set; }

    public string? ER { get; set; }

    public string? PR { get; set; }

    public string? Her2Neu { get; set; }

    public string? Ki67 { get; set; }

    public string? Notes { get; set; }

    public bool? IsReexamination { get; set; }

    public string? SRPaReexaminationType { get; set; }

    public string? ReferenceNo { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
