using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_TransPrescriptionFromSOAP
{
    public string RegistrationNo { get; set; } = null!;

    public DateTime PrescriptionDate { get; set; }
}
