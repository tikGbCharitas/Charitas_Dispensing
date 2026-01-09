using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ZipCode
{
    public string ZipCode1 { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string? District { get; set; }

    public string? County { get; set; }

    public string? City { get; set; }

    public string? SRProvince { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
