using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class Diet
{
    public string DietID { get; set; } = null!;

    public string DietName { get; set; } = null!;

    public string SRDietType { get; set; } = null!;

    public string MenuID { get; set; } = null!;

    public decimal Calorie { get; set; }

    public decimal CalorieMin { get; set; }

    public decimal CalorieMax { get; set; }

    public decimal CalorieInterval { get; set; }

    public decimal Protein { get; set; }

    public decimal ProteinMin { get; set; }

    public decimal ProteinMax { get; set; }

    public decimal ProteinInterval { get; set; }

    public decimal Fat { get; set; }

    public decimal FatMin { get; set; }

    public decimal FatMax { get; set; }

    public decimal FatInterval { get; set; }

    public decimal Carbohydrate { get; set; }

    public decimal CarbohydrateMin { get; set; }

    public decimal CarbohydrateMax { get; set; }

    public decimal CarbohydrateInterval { get; set; }

    public decimal Salt { get; set; }

    public decimal SaltMin { get; set; }

    public decimal SaltMax { get; set; }

    public decimal SaltInterval { get; set; }

    public decimal Fiber { get; set; }

    public decimal FiberMin { get; set; }

    public decimal FiberMax { get; set; }

    public decimal FiberInterval { get; set; }

    public string FormOfFood { get; set; } = null!;

    public short PriorityNo { get; set; }

    public bool IsGetSnack { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
