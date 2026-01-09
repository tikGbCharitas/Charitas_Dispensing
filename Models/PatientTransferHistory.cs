using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientTransferHistory
{
    public string RegistrationNo { get; set; } = null!;

    public string TransferNo { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string RoomID { get; set; } = null!;

    public string BedID { get; set; } = null!;

    public string ChargeClassID { get; set; } = null!;

    public DateTime? DateOfEntry { get; set; }

    public string? TimeOfEntry { get; set; }

    public DateTime? DateOfExit { get; set; }

    public string? TimeOfExit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SmfID { get; set; }

    public string? SmfIDBefore { get; set; }
}
