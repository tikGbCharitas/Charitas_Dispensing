using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationInfoMedical
{
    public long ID { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string SRMedicalNotesInputType { get; set; } = null!;

    public DateTime DateTimeInfo { get; set; }

    public string Info1 { get; set; } = null!;

    public string Info2 { get; set; } = null!;

    public string Info3 { get; set; } = null!;

    public string Info4 { get; set; } = null!;

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
