using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ZatActive
{
    public string ZatActiveID { get; set; } = null!;

    public string ZatActiveName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public string? InsertByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
