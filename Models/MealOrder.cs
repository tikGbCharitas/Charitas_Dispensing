using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MealOrder
{
    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime EffectiveDate { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string? BedID { get; set; }

    public string? DietPatientNo { get; set; }

    public string? DietID { get; set; }

    public string? MenuID { get; set; }

    public string? MenuItemID { get; set; }

    public string? FastingTime { get; set; }

    public bool? IsAdditional { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? VersionID { get; set; }

    public string? SeqNo { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string? VerifiedByUserID { get; set; }

    public string? Notes { get; set; }
}
