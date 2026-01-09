using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_TransactionItem
{
    public int TxType { get; set; }

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ParamedicCollectionName { get; set; } = null!;
}
