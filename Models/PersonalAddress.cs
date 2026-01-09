using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PersonalAddress
{
    public int PersonalAddressID { get; set; }

    public int PersonID { get; set; }

    public string SRAddressType { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string SRState { get; set; } = null!;

    public string? SRCity { get; set; }

    public string? ZipCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
