using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CssdSterileItemsReturned
{
    public string ReturnNo { get; set; } = null!;

    public DateTime ReturnDate { get; set; }

    public string ReturnTime { get; set; } = null!;

    public string ToServiceUnitID { get; set; } = null!;

    public string HandedByUserID { get; set; } = null!;

    public string ReceivedBy { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
