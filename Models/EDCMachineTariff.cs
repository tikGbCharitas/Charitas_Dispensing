using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class EDCMachineTariff
{
    public string EDCMachineID { get; set; } = null!;

    /// <summary>
    /// Visa, master, diner
    /// </summary>
    public string SRCardType { get; set; } = null!;

    public decimal EDCMachineTariff1 { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsChargedToPatient { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerID { get; set; }

    public virtual EDCMachine EDCMachine { get; set; } = null!;
}
