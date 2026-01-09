using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransChargesItemImage
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public int ImageNo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public byte[] DocumentImage { get; set; } = null!;

    public string? DocumentNotes { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string CreatedByUserID { get; set; } = null!;
}
