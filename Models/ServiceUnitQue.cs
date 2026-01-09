using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitQue
{
    public string ServiceUnitID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public DateTime QueDate { get; set; }

    public int QueNo { get; set; }

    public string? ServiceRoomID { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public bool IsClosed { get; set; }

    public bool? IsFromReferProcess { get; set; }

    public string Notes { get; set; } = null!;

    public bool? IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ParentNo { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public bool? IsStopped { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
