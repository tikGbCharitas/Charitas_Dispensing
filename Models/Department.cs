using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Department
{
    public string DepartmentID { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string Initial { get; set; } = null!;

    public string DepartmentManager { get; set; } = null!;

    public bool IsHasRegistration { get; set; }

    public bool IsAllowBackDateRegistration { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public virtual ICollection<ServiceUnit> ServiceUnits { get; set; } = new List<ServiceUnit>();
}
