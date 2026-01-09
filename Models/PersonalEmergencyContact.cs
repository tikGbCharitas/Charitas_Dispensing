using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalEmergencyContact
{
    public int PersonalEmergencyContactID { get; set; }

    public int PersonID { get; set; }

    public string ContactName { get; set; } = null!;

    public string? Address { get; set; }

    public string? SRState { get; set; }

    public string? SRCity { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
