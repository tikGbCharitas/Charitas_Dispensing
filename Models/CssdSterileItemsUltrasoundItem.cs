using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CssdSterileItemsUltrasoundItem
{
    public string TransactionNo { get; set; } = null!;

    public string TransactionSeqNo { get; set; } = null!;

    public string ReceivedNo { get; set; } = null!;

    public string ReceivedSeqNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
