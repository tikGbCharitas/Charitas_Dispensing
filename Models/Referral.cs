using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Referral
{
    public string ReferralID { get; set; } = null!;

    public string ReferralName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public string SRReferralGroup { get; set; } = null!;

    public string TaxRegistrationNo { get; set; } = null!;

    public bool IsPKP { get; set; }

    public string? TermID { get; set; }

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

    public bool IsRefferalFrom { get; set; }

    public bool IsRefferalTo { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? ParamedicID { get; set; }
}
