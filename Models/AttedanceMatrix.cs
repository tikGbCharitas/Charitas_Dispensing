using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AttedanceMatrix
{
    public int AttedanceMatrixID { get; set; }

    public string? AttedanceMatrixName { get; set; }

    public string? AttedanceMatrixFieldt { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
