using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RecruitmentMethod
{
    public int RecruitmentMethodID { get; set; }

    public int PersonnelRequisitionID { get; set; }

    public string SRRecruitmentMethod { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
