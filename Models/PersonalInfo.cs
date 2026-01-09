using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalInfo
{
    public int PersonID { get; set; }

    public string EmployeeNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? PreTitle { get; set; }

    public string? PostTitle { get; set; }

    public string? BirthName { get; set; }

    public string? PlaceBirth { get; set; }

    public DateTime BirthDate { get; set; }

    public string? KTPNo { get; set; }

    public string SRGenderType { get; set; } = null!;

    public string SRReligion { get; set; } = null!;

    public string SRSalutation { get; set; } = null!;

    public string? SRBloodType { get; set; }

    public string SRMaritalStatus { get; set; } = null!;

    public string? Picture { get; set; }

    public string? PatientID { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? CoverageClass { get; set; }

    public string? CoverageClassBPJS { get; set; }
}
