using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeByServiceSetting
{
    public int Id { get; set; }

    public string SRRegistrationType { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string SRParamedicFeeCaseType { get; set; } = null!;

    public string SRParamedicFeeIsTeam { get; set; } = null!;

    public string SRParamedicFeeTeamStatus { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public bool IsFeeValueInPercent { get; set; }

    public decimal FeeValue { get; set; }

    public int CountMax { get; set; }

    public string CreatedByUserID { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public bool? IsReplacementForFeeByPercentageOfAR { get; set; }
}
