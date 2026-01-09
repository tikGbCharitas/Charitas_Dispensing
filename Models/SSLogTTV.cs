using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SSLogTTV
{
    public int ID { get; set; }

    public string EncounterID { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string RequestType { get; set; } = null!;

    public string? ResponseReferenceID { get; set; }

    public string? ResponseStatus { get; set; }

    public string? ResponseNote { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public DateTime? ResponseDateTime { get; set; }
}
