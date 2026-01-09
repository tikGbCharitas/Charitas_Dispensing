using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationDischargeDetail
{
    public string RegistrationNo { get; set; } = null!;

    public string? ParamedicID { get; set; }

    public string? ParamedicName { get; set; }

    public string? SRUnitIntended { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? OtherExamination { get; set; }
}
