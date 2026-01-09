using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_RegistrationForMappingCOA
{
    public string RegistrationNo { get; set; } = null!;

    public string? SRRegistrationType { get; set; }

    public string? SRRegistrationTypeMergeTo { get; set; }

    public string? SRGuarantorIncomeGroup { get; set; }

    public string ClassID { get; set; } = null!;
}
