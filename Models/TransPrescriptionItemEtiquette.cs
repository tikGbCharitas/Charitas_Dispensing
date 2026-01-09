using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionItemEtiquette
{
    public string PrescriptionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public string ConsumeMethod { get; set; } = null!;

    public string Keeping { get; set; } = null!;

    public string? SpecificInfo { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public bool IsDrugOutside { get; set; }

    public string? CreateUserID { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public int? NumberOfCopies { get; set; }
}
