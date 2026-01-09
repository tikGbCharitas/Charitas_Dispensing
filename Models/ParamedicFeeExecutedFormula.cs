using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeExecutedFormula
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string? ExecutedFormula { get; set; }
}
