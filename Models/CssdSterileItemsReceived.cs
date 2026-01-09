using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CssdSterileItemsReceived
{
    public string ReceivedNo { get; set; } = null!;

    public DateTime ReceivedDate { get; set; }

    public string ReceivedTime { get; set; } = null!;

    public string FromServiceUnitID { get; set; } = null!;

    public string? FromRoomID { get; set; }

    public string? SenderByID { get; set; }

    public string SenderBy { get; set; } = null!;

    public string ReceivedByUserID { get; set; } = null!;

    public bool? IsFromProductionOfGoods { get; set; }

    public string? ProductionNo { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
