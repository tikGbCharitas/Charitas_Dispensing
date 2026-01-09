using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BedRoomIn
{
    public string BedID { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public DateTime DateOfEntry { get; set; }

    public string TimeOfEntry { get; set; } = null!;

    public DateTime? DateOfExit { get; set; }

    public string? TimeOfExit { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
