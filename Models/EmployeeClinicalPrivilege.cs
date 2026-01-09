using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeClinicalPrivilege
{
    public int EmployeeClinicalPrivilegeID { get; set; }

    public int PersonID { get; set; }

    public string SRProfessionGroup { get; set; } = null!;

    public string SRClinicalWorkArea { get; set; } = null!;

    public string SRClinicalAuthorityLevel { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string? DecreeNo { get; set; }

    public string? TransactionNo { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SRClinicalPrivilegeStatus { get; set; }

    public string? Reason { get; set; }

    public DateTime? LastUpdateStatusDateTime { get; set; }

    public string? LastUpdateStatusByUserID { get; set; }
}
