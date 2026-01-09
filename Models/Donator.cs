using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Donator
{
    public string DonatorID { get; set; } = null!;

    public string DonatorName { get; set; } = null!;

    public string? ShortName { get; set; }

    public string? StreetName { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? PhoneNo { get; set; }

    public string? FaxNo { get; set; }

    public string? ContactPerson { get; set; }

    public string? MobilePhoneNo { get; set; }

    public string? Email { get; set; }

    public string? DonatorNotes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
