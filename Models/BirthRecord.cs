using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BirthRecord
{
    public string RegistrationNo { get; set; } = null!;

    public string? MotherMedicalNo { get; set; }

    public string? MotherRegistrationNo { get; set; }

    public string? TimeOfBirth { get; set; }

    public string? SRBornAt { get; set; }

    public string? BornAtDescription { get; set; }

    public string? SRSingleTwin { get; set; }

    public string? TwinNo { get; set; }

    public string? SRBirthMethod { get; set; }

    public string? SRCaesarMethod { get; set; }

    public string? SRBornCondition { get; set; }

    public string? SRBirthComplication { get; set; }

    public string? SRDeathCondition { get; set; }

    public string? SRBirthIndication { get; set; }

    public decimal? BirthPregnancyAge { get; set; }

    public decimal? Length { get; set; }

    public decimal? Weight { get; set; }

    public decimal? ApgarScore1 { get; set; }

    public decimal? ApgarScore2 { get; set; }

    public decimal? ApgarScore3 { get; set; }

    public decimal? HeadCircumference { get; set; }

    public decimal? ChestCircumference { get; set; }

    public string? CertificateNo { get; set; }

    public string? FatherName { get; set; }

    public string? FatherSsn { get; set; }

    public DateTime? FatherBirthOfDate { get; set; }

    public string? StreetName { get; set; }

    public string? District { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? SROccupation { get; set; }

    public string? PhoneNo { get; set; }

    public string? FaxNo { get; set; }

    public string? MobilePhoneNo { get; set; }

    public string? Email { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? Notes { get; set; }

    public decimal? AbdomenCircumference { get; set; }

    public short? ChildNo { get; set; }

    public bool? IsEyesSmeared { get; set; }

    public string? EyesSmearedNotes { get; set; }

    public bool? IsAnusExamined { get; set; }

    public string? AnusExaminedNotes { get; set; }
}
