using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class HospitalInfo
{
    public int HospitalInfoID { get; set; }

    public string HospitalName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string SRState { get; set; } = null!;

    public string? SRCity { get; set; }

    public string? ZipCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
