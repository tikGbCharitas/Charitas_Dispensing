using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeTaxCalculation
{
    public long id { get; set; }

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public string SRPphType { get; set; } = null!;

    public short Period { get; set; }

    public bool IsNpwp { get; set; }

    public decimal TaxInPercent { get; set; }

    public decimal FeeAmount { get; set; }

    public decimal FeeAmountAccumulated { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal TaxAmountAccumulated { get; set; }

    public string? VerificationNo { get; set; }

    public string InsertByUserID { get; set; } = null!;

    public DateTime InsertDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public long? JournalID { get; set; }

    public bool? IsTaxFromPayment { get; set; }

    public bool? IsPaymentApproved { get; set; }

    public string? PaymentGroupNo { get; set; }
}
