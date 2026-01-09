using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Snack
{
    public string SnackID { get; set; } = null!;

    public string SnackName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
