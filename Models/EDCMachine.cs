using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EDCMachine
{
    public string EDCMachineID { get; set; } = null!;

    /// <summary>
    /// Lippo, BCA, BNI
    /// </summary>
    public string SRCardProvider { get; set; } = null!;

    public string EDCMachineName { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public int? ChartOfAccountID { get; set; }

    public int? SubledgerID { get; set; }

    public virtual ICollection<EDCMachineTariff> EDCMachineTariffs { get; set; } = new List<EDCMachineTariff>();
}
