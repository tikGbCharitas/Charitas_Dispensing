using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppUser_old
{
    public string UserID { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string SRLanguage { get; set; } = null!;

    public DateTime ActiveDate { get; set; }

    public DateTime ExpireDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ParamedicID { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? LicenseNo { get; set; }

    public int? PersonID { get; set; }

    public string? Email { get; set; }
}
