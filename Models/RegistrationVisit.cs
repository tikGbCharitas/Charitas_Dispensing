using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationVisit
{
    public string RegistrationNo { get; set; } = null!;

    public int VisitNo { get; set; }

    public DateTime? VisitDateTime { get; set; }

    public string? VisitNotes { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? RoomID { get; set; }

    public string? BedID { get; set; }
}
