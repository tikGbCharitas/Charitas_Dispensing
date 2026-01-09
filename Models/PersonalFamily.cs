using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalFamily
{
    public int PersonalFamilyID { get; set; }

    public int PersonID { get; set; }

    public string? PatientID { get; set; }

    public string SRFamilyRelation { get; set; } = null!;

    public string FamilyName { get; set; } = null!;

    public string? CityOfBirth { get; set; }

    public DateTime DateBirth { get; set; }

    public string? SREducationLevel { get; set; }

    public string? Address { get; set; }

    public string? SRState { get; set; }

    public string? SRCity { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public string? SRMaritalStatus { get; set; }

    public string? SRGenderType { get; set; }

    public bool? IsGuaranteed { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? SRCoverageType { get; set; }

    public string? BPJSKesehatanNo { get; set; }
}
