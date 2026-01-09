using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CssdSterileItemsUltrasound
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string TransactionTime { get; set; } = null!;

    public string TransactionByUserID { get; set; } = null!;

    public bool IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
