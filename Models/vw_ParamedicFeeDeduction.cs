using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_ParamedicFeeDeduction
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public int DeductionID { get; set; }

    public string? RegistrationNo { get; set; }

    public string? RegistrationNoMergeTo { get; set; }

    public bool IsCalculatedInPercent { get; set; }

    public string? VerificationNo { get; set; }

    public decimal CalculatedAmount { get; set; }

    public decimal DeductionAmount { get; set; }

    public string CreatedByUserID { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string? SRParamedicFeeDeduction { get; set; }
}
