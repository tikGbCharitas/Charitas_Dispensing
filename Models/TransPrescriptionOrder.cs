using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionOrder
{
    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string FromServiceUnitID { get; set; } = null!;

    public string ToServiceUnitID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public bool IsComplete { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsPrescriptionReturn { get; set; }
}
