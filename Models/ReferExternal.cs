using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ReferExternal
{
    public string RegistrationNo { get; set; } = null!;

    public string? ReferralID { get; set; }

    public string? SRReferReason { get; set; }

    public string? ReferReasonOther { get; set; }

    public string? OtherInformation { get; set; }

    public string? ReferralAgreedBy { get; set; }

    public DateTime? ReferralAgreedTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
