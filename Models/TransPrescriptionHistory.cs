using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescriptionHistory
{
    public string RecalculationProcessNo { get; set; } = null!;

    public string PrescriptionNo { get; set; } = null!;

    public DateTime PrescriptionDate { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string ClassID { get; set; } = null!;

    public string ParamedicID { get; set; } = null!;

    public bool IsApproval { get; set; }

    public bool IsVoid { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserID { get; set; } = null!;

    public bool IsPrescriptionReturn { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public bool IsFromSOAP { get; set; }

    public bool IsBillProceed { get; set; }

    public bool IsUnitDosePrescription { get; set; }

    public bool IsCito { get; set; }

    public bool IsClosed { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public DateTime? DeliverDateTime { get; set; }
}
