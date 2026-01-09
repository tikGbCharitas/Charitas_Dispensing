using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class StructuralBenefit
{
    public int OrganizationUnitID { get; set; }

    public int PositionID { get; set; }

    public DateTime ValidFrom { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
