using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_ItemServicesRlReport
{
    public string ItemID { get; set; } = null!;

    public int? RlMasterReportItemID { get; set; }
}
