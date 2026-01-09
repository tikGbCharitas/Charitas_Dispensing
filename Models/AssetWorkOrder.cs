using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AssetWorkOrder
{
    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public string FromServiceUnitID { get; set; } = null!;

    public string ToServiceUnitID { get; set; } = null!;

    public string AssetID { get; set; } = null!;

    public string? ItemID { get; set; }

    public decimal? Qty { get; set; }

    public string ProblemDescription { get; set; } = null!;

    public string SRWorkStatus { get; set; } = null!;

    public string? SRWorkType { get; set; }

    public string? SRWorkPriority { get; set; }

    public string? SRWorkTrade { get; set; }

    public DateTime? RequiredDate { get; set; }

    public string? RequestByUserID { get; set; }

    public DateTime? ReceivedDateTime { get; set; }

    public string? ReceivedByUserID { get; set; }

    public string? SRFailureCode { get; set; }

    public string? FailureCauseDescription { get; set; }

    public string? ActionTaken { get; set; }

    public string? PreventionTaken { get; set; }

    public decimal? CostEstimation { get; set; }

    public string? LastRealizationByUserID { get; set; }

    public DateTime? LastRealizationDateTime { get; set; }

    public string? AcceptedByUserID { get; set; }

    public DateTime? AcceptedDateTime { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public bool? IsProceed { get; set; }

    public bool? IsPreventiveMaintenance { get; set; }

    public string? PMNo { get; set; }

    public bool? IsGeneratePrDr { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ImplementedBy { get; set; }

    public string? AcceptedBy { get; set; }

    public string? SentToThirdPartiesByUserID { get; set; }

    public DateTime? SentToThirdPartiesDateTime { get; set; }

    public string? ReceivedFromThirdPartiesByUserID { get; set; }

    public DateTime? ReceivedFromThirdPartiesDateTime { get; set; }

    public string? ReceivedFromLogisticsByUserID { get; set; }

    public DateTime? ReceivedFromLogisticsDateTime { get; set; }

    public string? ReferenceNo { get; set; }

    public string? LetterNo { get; set; }

    public string? SupplierID { get; set; }

    public DateTime? FirstResponseDateTime { get; set; }

    public string? FirstResponseByUserID { get; set; }
}
