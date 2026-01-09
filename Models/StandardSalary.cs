using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class StandardSalary
{
    public int StandardSalaryID { get; set; }

    public int PositionGradeID { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
