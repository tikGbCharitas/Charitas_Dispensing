using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TransPrescription
{
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

    public string? TextPrescription { get; set; }

    public bool? IsDirect { get; set; }

    public bool? IsPaid { get; set; }

    public string? OrderNo { get; set; }

    public bool? IsProceedByPharmacist { get; set; }

    public string? FullAddress { get; set; }

    public string? NoTelp { get; set; }

    public string? AdditionalNote { get; set; }

    public string? SRFloor { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public short? QtyR { get; set; }

    public string? ApprovedByUserID { get; set; }

    public bool? IsPrinted { get; set; }

    public int? FloorSeqNo { get; set; }

    public string? Rtype { get; set; }

    public string? FromServiceUnitID { get; set; }

    public string? FromRoomID { get; set; }

    public string? FromBedID { get; set; }

    public string? LocationID { get; set; }

    public DateTime? CompleteDateTime { get; set; }

    public string? VoidReason { get; set; }

    public bool? IsForTakeItHome { get; set; }

    public string? SRPrescriptionCategory { get; set; }

    public bool? IsReviewed { get; set; }

    public string? ReviewedByUserID { get; set; }

    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsRead { get; set; }

    public string? CompletedByUserID { get; set; }

    public string? DeliveredByUserID { get; set; }

    public string? QCByUserID { get; set; }

    public DateTime? QCDateTime { get; set; }

    public virtual ICollection<TransPrescriptionItem> TransPrescriptionItems { get; set; } = new List<TransPrescriptionItem>();
}
