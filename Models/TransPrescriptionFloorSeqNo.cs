using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionFloorSeqNo
{
    public DateTime PrescriptionDate { get; set; }

    public string SRFloor { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string ShiftID { get; set; } = null!;

    public string Rtype { get; set; } = null!;

    public int? SeqNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
