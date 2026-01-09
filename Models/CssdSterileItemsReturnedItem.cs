using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CssdSterileItemsReturnedItem
{
    public string ReturnNo { get; set; } = null!;

    public string ReturnSeqNo { get; set; } = null!;

    public string ProcessNo { get; set; } = null!;

    public string ProcessSeqNo { get; set; } = null!;

    public decimal? Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
