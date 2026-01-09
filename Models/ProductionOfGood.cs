using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ProductionOfGood
{
    public string ProductionNo { get; set; } = null!;

    public DateTime ProductionDate { get; set; }

    public string ServiceUnitID { get; set; } = null!;

    public string LocationID { get; set; } = null!;

    public string FormulaID { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal Price { get; set; }

    public decimal CostAmount { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ToServiceUnitID { get; set; }
}
