using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ApplicantInfo
{
    public int ApplicantID { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string SRApplicantStatus { get; set; } = null!;

    public DateTime DateApplied { get; set; }

    public DateTime? DateAvailable { get; set; }

    public int? ExpectedSalary { get; set; }

    public string? SRCurrencyCode { get; set; }

    public string? JobOpportunityReferenceNo { get; set; }

    public DateTime? SendRejectionDate { get; set; }

    public int? KeepOnFileDuration { get; set; }

    public string? Note { get; set; }

    public string? SRApplicantSource { get; set; }

    public string Address { get; set; } = null!;

    public string SRState { get; set; } = null!;

    public string? SRCity { get; set; }

    public string? ZipCode { get; set; }

    public string? PlaceBirth { get; set; }

    public DateTime BirthDate { get; set; }

    public string? KTPNo { get; set; }

    public string SRGenderType { get; set; } = null!;

    public string SRReligion { get; set; } = null!;

    public string? SRBloodType { get; set; }

    public string SRMaritalStatus { get; set; } = null!;

    public string? Picture { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
