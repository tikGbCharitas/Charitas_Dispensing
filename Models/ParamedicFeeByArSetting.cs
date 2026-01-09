using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeByArSetting
{
    public int Id { get; set; }

    public string SRRegistrationType { get; set; } = null!;

    public bool IsMergeToIPR { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string SRParamedicFeeCaseType { get; set; } = null!;

    public string SRParamedicFeeIsTeam { get; set; } = null!;

    public int LosStart { get; set; }

    public int LosEnd { get; set; }

    public string SRParamedicFeeTeamStatus { get; set; } = null!;

    public bool IsFeeValueInPercent { get; set; }

    public decimal FeeValue { get; set; }

    public string CreatedByUserID { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string? SmfID { get; set; }
}
