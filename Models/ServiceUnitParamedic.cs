using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitParamedic
{
    public string ServiceUnitID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? DefaultRoomID { get; set; }

    public bool? IsUsingQue { get; set; }
}
