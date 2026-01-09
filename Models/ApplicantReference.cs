using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ApplicantReference
{
    public int ApplicantReferencesID { get; set; }

    public int ApplicantID { get; set; }

    public string ReferencesName { get; set; } = null!;

    public string? Relationship { get; set; }

    public string? OrganizationName { get; set; }

    public string? JobTitle { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
