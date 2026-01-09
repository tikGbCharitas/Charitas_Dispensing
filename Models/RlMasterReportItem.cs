using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RlMasterReportItem
{
    public int RlMasterReportItemID { get; set; }

    public int RlMasterReportID { get; set; }

    public string RlMasterReportItemNo { get; set; } = null!;

    public string RlMasterReportItemCode { get; set; } = null!;

    public string RlMasterReportItemName { get; set; } = null!;

    public string SRParamedicRL1 { get; set; } = null!;

    public bool IsActive { get; set; }

    public string ParameterValue { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
