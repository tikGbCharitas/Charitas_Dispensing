using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationCounseling
{
    public string RegistrationNo { get; set; } = null!;

    public int CounselingNo { get; set; }

    public DateTime? CounselingDateTime { get; set; }

    public string? CounselingNotes { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? RoomID { get; set; }

    public string? BedID { get; set; }
}
