using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationResponsiblePerson
{
    public string RegistrationNo { get; set; } = null!;

    public string? NameOfTheResponsible { get; set; }

    public string? SRRelationship { get; set; }

    public string? SROccupation { get; set; }

    public string? HomeAddress { get; set; }

    public string? PhoneNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? JobDescription { get; set; }

    public string? Ssn { get; set; }
}
