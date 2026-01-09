using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicTeam
{
    public string RegistrationNo { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string SRParamedicTeamStatus { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
