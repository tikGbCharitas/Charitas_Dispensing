using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AbsentCode
{
    public int AbsentCodeID { get; set; }

    public string AbsentCode1 { get; set; } = null!;

    public string AbsentName { get; set; } = null!;

    public string SRCodeClasification { get; set; } = null!;

    public string SRManagementType { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public bool? IsBit { get; set; }
}
