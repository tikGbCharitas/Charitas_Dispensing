using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicFeeVerificationRentalRoom
{
    public string VerificationNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentID { get; set; } = null!;

    public decimal RentalRoomsAmount { get; set; }

    public decimal TogethernessAmount { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
