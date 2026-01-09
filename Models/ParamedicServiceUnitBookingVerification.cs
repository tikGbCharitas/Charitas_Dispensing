using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ParamedicServiceUnitBookingVerification
{
    public int ParamedicServiceUnitBookingVerificationID { get; set; }

    public int ServiceUnitBookingVerificationID { get; set; }

    public string ParamedicID { get; set; } = null!;

    public virtual Paramedic Paramedic { get; set; } = null!;

    public virtual ServiceUnitBookingVerification ServiceUnitBookingVerification { get; set; } = null!;
}
