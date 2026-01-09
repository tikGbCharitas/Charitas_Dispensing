using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ApplicantFamily
{
    public int ApplicantFamilyID { get; set; }

    public int ApplicantID { get; set; }

    public string SRFamilyRelation { get; set; } = null!;

    public string FamilyName { get; set; } = null!;

    public DateTime DateBirth { get; set; }

    public string? SREducationLevel { get; set; }

    public string? Address { get; set; }

    public string? SRMaritalStatus { get; set; }

    public string? SRGenderType { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
