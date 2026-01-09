using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SSEncounterRegPoli
{
    public int ID { get; set; }

    public string? EncounterStatus { get; set; }

    public string? RegistrationNo { get; set; }

    public string? EncounterID { get; set; }

    public string? RequestData { get; set; }

    public string? ResponseData { get; set; }

    public string? ResponseStatus { get; set; }

    public DateTime? CreateDate { get; set; }
}
