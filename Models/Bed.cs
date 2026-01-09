using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Bed
{
    public string BedID { get; set; } = null!;

    public string RoomID { get; set; } = null!;

    public string? RegistrationNo { get; set; }

    public string ClassID { get; set; } = null!;

    public string SRBedStatus { get; set; } = null!;

    public string BedStatusUpdatedBy { get; set; } = null!;

    public bool IsTemporary { get; set; }

    public bool IsActive { get; set; }

    public bool? IsNeedConfirmation { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsRoomIn { get; set; }

    public DateTime? BookingDateTime { get; set; }

    public bool? IsVisibleTo3rdParty { get; set; }

    public string? BedStatusNote { get; set; }
}
