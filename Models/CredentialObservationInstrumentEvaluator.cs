using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialObservationInstrumentEvaluator
{
    public string TransactionNo { get; set; } = null!;

    public int EvaluatorID { get; set; }

    public string SRCredentialEvaluatorNo { get; set; } = null!;

    public string SRCredentialEvaluatorRole { get; set; } = null!;

    public bool? IsEvaluated { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
