using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class MedicalRecordFileStatus
{
    public string RegistrationNo { get; set; } = null!;

    public DateTime? FileOutDate { get; set; }

    public DateTime? FileInDate { get; set; }

    public string? SRMedicalFileCategory { get; set; }

    public string? SRMedicalFileStatus { get; set; }

    public string? Notes { get; set; }

    public string? RequestByUserID { get; set; }

    public string? ReceiptByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? FileOutDateConfirmed { get; set; }

    public string? FileOutUserIDComfirmed { get; set; }
}
