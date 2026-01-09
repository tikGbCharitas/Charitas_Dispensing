using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class JournalTransactionDetail
{
    public int DetailId { get; set; }

    public int JournalId { get; set; }

    public int ChartOfAccountId { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string Description { get; set; } = null!;

    public int SubLedgerId { get; set; }

    public string DocumentNumber { get; set; } = null!;

    public int? DocumentPageNo { get; set; }

    public string? ClassID { get; set; }

    public string? GuarantorID { get; set; }

    public string? SupplierID { get; set; }

    public string? ParamedicID { get; set; }

    public DateTime? DueDate { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? ItemID { get; set; }

    public string? DocumentNumberSequenceNo { get; set; }

    public string? RegistrationNo { get; set; }

    public string? TariffComponentID { get; set; }

    public virtual ChartOfAccount ChartOfAccount { get; set; } = null!;

    public virtual JournalTransaction Journal { get; set; } = null!;
}
