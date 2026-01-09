using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeePosition
{
    public int EmployeePositionID { get; set; }

    public int PersonID { get; set; }

    public int PositionID { get; set; }

    public bool IsPrimaryPosition { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public string? AssignmentNo { get; set; }

    public string? ResignmentNo { get; set; }
}
