using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_TransactionItemMerge
{
    public string Label { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemID { get; set; } = null!;
}
