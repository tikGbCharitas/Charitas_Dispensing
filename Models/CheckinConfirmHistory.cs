using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CheckinConfirmHistory
{
    public Guid CheckinConfirmId { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string TransferNo { get; set; } = null!;

    public string BedID { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
