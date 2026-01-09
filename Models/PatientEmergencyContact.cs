using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientEmergencyContact
{
    public string PatientID { get; set; } = null!;

    public string ContactName { get; set; } = null!;

    public string SRRelationship { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string District { get; set; } = null!;

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? SROccupation { get; set; }

    public string? Ssn { get; set; }

    public virtual Patient Patient { get; set; } = null!;
}
