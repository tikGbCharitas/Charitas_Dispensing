using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Patient
{
    public string PatientID { get; set; } = null!;

    public string? MedicalNo { get; set; }

    public string Ssn { get; set; } = null!;

    public string SRSalutation { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string ParentSpouseName { get; set; } = null!;

    public string CityOfBirth { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string Sex { get; set; } = null!;

    public string SRBloodType { get; set; } = null!;

    public string BloodRhesus { get; set; } = null!;

    public string SREthnic { get; set; } = null!;

    public string SREducation { get; set; } = null!;

    public string SRMaritalStatus { get; set; } = null!;

    public string SRNationality { get; set; } = null!;

    public string SROccupation { get; set; } = null!;

    public string SRTitle { get; set; } = null!;

    public string SRPatientCategory { get; set; } = null!;

    public string SRReligion { get; set; } = null!;

    public string SRMedicalFileBin { get; set; } = null!;

    public string SRMedicalFileStatus { get; set; } = null!;

    public string? GuarantorID { get; set; }

    public string Company { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string District { get; set; } = null!;

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public string? TempAddressStreetName { get; set; }

    public string? TempAddressDistrict { get; set; }

    public string? TempAddressCity { get; set; }

    public string? TempAddressCounty { get; set; }

    public string? TempAddressState { get; set; }

    public string? TempAddressZipCode { get; set; }

    public string? TempAddressPhoneNo { get; set; }

    public DateTime? LastVisitDate { get; set; }

    public byte NumberOfVisit { get; set; }

    public string OldMedicalNo { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string PictureFileName { get; set; } = null!;

    public bool IsDonor { get; set; }

    public decimal NumberOfDonor { get; set; }

    public DateTime? LastDonorDate { get; set; }

    public bool IsBlackList { get; set; }

    public bool IsAlive { get; set; }

    public bool IsActive { get; set; }

    public string Notes { get; set; } = null!;

    public string DiagnosticNo { get; set; } = null!;

    public string? MemberID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public decimal? PackageBalance { get; set; }

    public string? HealthcareID { get; set; }

    public TimeOnly? ResponTime { get; set; }

    public string? SRInformationFrom { get; set; }

    public string? SRPatienRelation { get; set; }

    public int? PersonID { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? SREmployeeRelationship { get; set; }

    public string? GuarantorCardNo { get; set; }

    public bool? IsNonPatient { get; set; }

    public short? ParentSpouseAge { get; set; }

    public string? SRParentSpouseOccupation { get; set; }

    public string? ParentSpouseOccupationDesc { get; set; }

    public string? SRMotherOccupation { get; set; }

    public string? MotherOccupationDesc { get; set; }

    public string? MotherName { get; set; }

    public short? MotherAge { get; set; }

    public bool? IsNotPaidOff { get; set; }

    public string? ParentSpouseMedicalNo { get; set; }

    public string? MotherMedicalNo { get; set; }

    public string? CompanyAddress { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? SRRelationshipQuality { get; set; }

    public string? SRResidentialHome { get; set; }

    public bool? IsStoredToLokadok { get; set; }

    public string? FatherName { get; set; }

    public short? FatherAge { get; set; }

    public string? FatherMedicalNo { get; set; }

    public string? SRFatherOccupation { get; set; }

    public string? FatherOccupationDesc { get; set; }

    public string? DeathCertificateNo { get; set; }

    public bool? IsVIP { get; set; }

    public bool? IsPejabat { get; set; }

    public string? NotesVIP { get; set; }

    public string? IDwilayah { get; set; }

    public string? SatuSehatID { get; set; }

    public string? SatuSehatName { get; set; }

    public virtual PatientEmergencyContact? PatientEmergencyContact { get; set; }
}
