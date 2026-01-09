using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_JasaRaharjaLog
{
    public int LogId { get; set; }

    public byte? OperationType { get; set; }

    public DateTime? SendDateTime { get; set; }

    public string? SendParameter { get; set; }

    public string? ReceiveResult { get; set; }

    public string? RegistrationNo { get; set; }

    public bool? IsOperationSuccess { get; set; }

    public string? MedicalNo { get; set; }
}
