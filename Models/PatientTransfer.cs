using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PatientTransfer
{
    public string TransferNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string DepartmentID { get; set; } = null!;

    public string TransactionCode { get; set; } = null!;

    public DateTime TransferDate { get; set; }

    public string TransferTime { get; set; } = null!;

    public string FromServiceUnitID { get; set; } = null!;

    public string FromClassID { get; set; } = null!;

    public string FromRoomID { get; set; } = null!;

    public string FromBedID { get; set; } = null!;

    public string FromChargeClassID { get; set; } = null!;

    public string FromSpecialtyID { get; set; } = null!;

    public string ToServiceUnitID { get; set; } = null!;

    public string ToClassID { get; set; } = null!;

    public string ToRoomID { get; set; } = null!;

    public string ToBedID { get; set; } = null!;

    public string ToChargeClassID { get; set; } = null!;

    public string ToSpecialtyID { get; set; } = null!;

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public bool? IsRoomInFrom { get; set; }

    public bool? IsRoomInTo { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
