using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Award
{
    public int AwardID { get; set; }

    public string AwardCode { get; set; } = null!;

    public string AwardName { get; set; } = null!;

    public string SRAwardCriteria { get; set; } = null!;

    public string SRAwardType { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string AwardPrize { get; set; } = null!;

    public string Note { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
