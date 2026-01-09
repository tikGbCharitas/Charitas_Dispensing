using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EmployeeRL4
{
    public int EmployeeRL4ID { get; set; }

    public int PersonID { get; set; }

    public int CompanyEducationProfileID { get; set; }

    public int CompanyFieldOfWorkProfileID { get; set; }

    public string SRRL4Status { get; set; } = null!;

    public string SRRL4Type { get; set; } = null!;

    public string SRMedisType { get; set; } = null!;

    public string SREducationLevel { get; set; } = null!;

    public int RL4EducationID { get; set; }

    public bool IsActive { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;
}
