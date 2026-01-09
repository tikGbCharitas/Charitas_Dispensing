using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientFluidBalanceDetail
{
    public string RegistrationNo { get; set; } = null!;

    public int SequenceNo { get; set; }

    public int DetailSequenceNo { get; set; }

    public DateTime InOutDateTime { get; set; }

    public string SRFluidInOutMethod { get; set; } = null!;

    public string FluidName { get; set; } = null!;

    public decimal? FluidQty { get; set; }

    public decimal? InOutQty { get; set; }

    public string? Note { get; set; }

    public string CreatedByUserID { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
