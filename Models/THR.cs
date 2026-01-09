using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class THR
{
    public int PersonID { get; set; }

    public string EmployeeName { get; set; } = null!;

    public decimal Tax_Allowance { get; set; }

    public decimal Total_THR { get; set; }

    public decimal Dpp { get; set; }

    public decimal PKP { get; set; }

    public decimal Pph_21_Setahun { get; set; }

    public decimal Pph_21 { get; set; }

    public decimal THR1 { get; set; }
}
