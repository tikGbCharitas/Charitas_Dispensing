using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialProcess
{
    public string TransactionNo { get; set; } = null!;

    public string QuestionFormID { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public int PersonID { get; set; }

    public string SRProfessionGroup { get; set; } = null!;

    public string SRClinicalWorkArea { get; set; } = null!;

    public string SRClinicalAuthorityLevel { get; set; } = null!;

    public int QuestionnaireID { get; set; }

    public string? SREducationalQualification { get; set; }

    public string? EducationalInstitution { get; set; }

    public string? DiplomaNumber { get; set; }

    public DateTime? DiplomaDate { get; set; }

    public string? CompetencyCertificateNo { get; set; }

    public DateTime? CompetencyCertificateDateOfIssue { get; set; }

    public string SRCredentialingStatus { get; set; } = null!;

    public string SRRecredentialReason { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public bool? IsDocumentComplete { get; set; }

    public string? DocumentIncompleteNotes { get; set; }

    public bool? IsDocumentChecking { get; set; }

    public DateTime? DocumentCheckingDateTime { get; set; }

    public string? DocumentCheckingByUserID { get; set; }

    public int? EthicsQuestionnariePersonID { get; set; }

    public DateTime? EthicsQuestionnarieDate { get; set; }

    public string? EthicsQuestionnarieByUserID { get; set; }

    public DateTime? LastEthicsQuestionnarieDateTime { get; set; }

    public DateTime? CompetencyAssessmentDate { get; set; }

    public string? CompetencyAssessmentByUserID { get; set; }

    public DateTime? LastCompetencyAssessmentDateTime { get; set; }

    public int? ObservationInstrumentQuestionnaireID { get; set; }

    public bool? IsCompletelyObservationInstrumentAssessment { get; set; }

    public decimal? ObservationInstrumentAssessmentScore { get; set; }

    public DateTime? LastObservationInstrumentAssessmentDateTime { get; set; }

    public string? LastObservationInstrumentAssessmentByUserID { get; set; }

    public string? DispositionNo { get; set; }

    public DateTime? ScheduleDate { get; set; }

    public string? ScheduleTimeFrom { get; set; }

    public string? ScheduleTimeTo { get; set; }

    public string? CredentialingLocation { get; set; }

    public string? CredentialingInvitationLetterNo { get; set; }

    public string? InvitationNo { get; set; }

    public DateTime? SchedulingDateTime { get; set; }

    public string? SchedulingByUserID { get; set; }

    public bool? IsRecommendation { get; set; }

    public DateTime? LastRecommendationDateTime { get; set; }

    public string? LastRecommendationByUserID { get; set; }

    public bool? IsRecommendationResult { get; set; }

    public DateTime? RecommendationResultDate { get; set; }

    public string? SRRecommendationResult { get; set; }

    public string? RecommendationResultNotes { get; set; }

    public DateTime? LastRecommendationResultDateTime { get; set; }

    public string? LastRecommendationResultByUserID { get; set; }

    public bool? IsConclusion { get; set; }

    public DateTime? ConclusionDate { get; set; }

    public string? SRConclusionResult { get; set; }

    public string? ConclusionNotes { get; set; }

    public string? SRCredentialingConclusion { get; set; }

    public string? CredentialingConclusionDesc { get; set; }

    public bool? IsPerform { get; set; }

    public DateTime? LastConclusionDateTime { get; set; }

    public string? LastConclusionByUserID { get; set; }

    public bool? IsReprocess { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ClinicalAppoinmentNo { get; set; }

    public DateTime? ClinicalAppoinmentDateOfIssue { get; set; }

    public DateTime? ClinicalAppoinmentValidTo { get; set; }

    public string? SRClinicalAppoinmentStatus { get; set; }

    public string? ClinicalAppoinmentNotes { get; set; }

    public DateTime? LastClinicalAppoinmentDateTime { get; set; }

    public string? LastClinicalAppoinmentByUserID { get; set; }

    public bool? IsCi { get; set; }

    public string? SRKtklLevel { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsVoidDisposition { get; set; }

    public string? VoidDispositionNotes { get; set; }

    public DateTime? VoidDispositionDateTime { get; set; }

    public string? VoidDispositionByUserID { get; set; }

    public bool? IsApprovedByDirector { get; set; }

    public DateTime? ApprovedByDirectorDateTime { get; set; }

    public string? ApprovedByDirectorUserID { get; set; }

    public string? LetterNoSubCommittee { get; set; }

    public string? LetterNoCommittee { get; set; }

    public string? MedicalWorkArea { get; set; }

    public string? MedicalFellowships { get; set; }
}
