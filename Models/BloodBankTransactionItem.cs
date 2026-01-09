using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class BloodBankTransactionItem
{
    public string TransactionNo { get; set; } = null!;

    public string BagNo { get; set; } = null!;

    public DateTime? ReceivedDate { get; set; }

    public string? ReceivedTime { get; set; }

    public string? SRBloodGroupReceived { get; set; }

    public string? CompletedTime { get; set; }

    public bool? IsScreeningLabelPassedPmi { get; set; }

    public bool? IsExpiredDate { get; set; }

    public bool? IsLeak { get; set; }

    public bool? IsHemolysis { get; set; }

    public bool? IsCrossMatchingSuitability { get; set; }

    public bool? IsClotting { get; set; }

    public bool? IsBloodTypeCompatibility { get; set; }

    public bool? IsLabelDonorsMatchesWithPatientsForm { get; set; }

    public bool? IsScreeningLabelPassedBd { get; set; }

    public string? ExaminerByUserID { get; set; }

    public string? UnitOfficer { get; set; }

    public DateTime? TransfusionDate { get; set; }

    public short? QtyTransfusion { get; set; }

    public string? SRBloodSource { get; set; }

    public string? SRBloodSourceFrom { get; set; }

    public string? CrossmatchCompatibleMajor { get; set; }

    public string? CrossmatchCompatibleMinor { get; set; }

    public string? BpPre { get; set; }

    public string? BpPost { get; set; }

    public decimal? PulsePre { get; set; }

    public decimal? PulsePost { get; set; }

    public decimal? TemperaturePre { get; set; }

    public decimal? TemperaturePost { get; set; }

    public decimal? RespiratoryPre { get; set; }

    public decimal? RespiratoryPost { get; set; }

    public bool? IsFever10 { get; set; }

    public bool? IsFever30 { get; set; }

    public bool? IsFever60 { get; set; }

    public bool? IsFever120 { get; set; }

    public bool? IsFever180 { get; set; }

    public bool? IsFever240 { get; set; }

    public bool? IsShivering10 { get; set; }

    public bool? IsShivering30 { get; set; }

    public bool? IsShivering60 { get; set; }

    public bool? IsShivering120 { get; set; }

    public bool? IsShivering180 { get; set; }

    public bool? IsShivering240 { get; set; }

    public bool? IsSob10 { get; set; }

    public bool? IsSob30 { get; set; }

    public bool? IsSob60 { get; set; }

    public bool? IsSob120 { get; set; }

    public bool? IsSob180 { get; set; }

    public bool? IsSob240 { get; set; }

    public bool? IsPainful10 { get; set; }

    public bool? IsPainful30 { get; set; }

    public bool? IsPainful60 { get; set; }

    public bool? IsPainful120 { get; set; }

    public bool? IsPainful180 { get; set; }

    public bool? IsPainful240 { get; set; }

    public bool? IsNausea10 { get; set; }

    public bool? IsNausea30 { get; set; }

    public bool? IsNausea60 { get; set; }

    public bool? IsNausea120 { get; set; }

    public bool? IsNausea180 { get; set; }

    public bool? IsNausea240 { get; set; }

    public bool? IsBleeding10 { get; set; }

    public bool? IsBleeding30 { get; set; }

    public bool? IsBleeding60 { get; set; }

    public bool? IsBleeding120 { get; set; }

    public bool? IsBleeding180 { get; set; }

    public bool? IsBleeding240 { get; set; }

    public bool? IsHypotension10 { get; set; }

    public bool? IsHypotension30 { get; set; }

    public bool? IsHypotension60 { get; set; }

    public bool? IsHypotension120 { get; set; }

    public bool? IsHypotension180 { get; set; }

    public bool? IsHypotension240 { get; set; }

    public bool? IsShock10 { get; set; }

    public bool? IsShock30 { get; set; }

    public bool? IsShock60 { get; set; }

    public bool? IsShock120 { get; set; }

    public bool? IsShock180 { get; set; }

    public bool? IsShock240 { get; set; }

    public bool? IsUrticaria10 { get; set; }

    public bool? IsUrticaria30 { get; set; }

    public bool? IsUrticaria60 { get; set; }

    public bool? IsUrticaria120 { get; set; }

    public bool? IsUrticaria180 { get; set; }

    public bool? IsUrticaria240 { get; set; }

    public string? OtherReaction { get; set; }

    public decimal? HemoglobinPre { get; set; }

    public decimal? HemoglobinPost { get; set; }

    public decimal? HematocritPre { get; set; }

    public decimal? HematocritPost { get; set; }

    public decimal? PlateletPre { get; set; }

    public decimal? PlateletPost { get; set; }

    public string? Action { get; set; }

    public string? TransfusionStartTime { get; set; }

    public string? TransfusionEndTime { get; set; }

    public string? TransfusionOfficer { get; set; }

    public bool? IsHiv { get; set; }

    public bool? IsVbrl { get; set; }

    public bool? IsHbsAg { get; set; }

    public bool? IsHcv { get; set; }

    public bool? IsReCheck { get; set; }

    public DateTime? ReCheckDateTime { get; set; }

    public bool? IsReCheckExpiredDate { get; set; }

    public bool? IsReCheckLeak { get; set; }

    public bool? IsReCheckHemolysis { get; set; }

    public bool? IsReCheckCrossMatchingSuitability { get; set; }

    public bool? IsReCheckClotting { get; set; }

    public bool? IsReCheckBloodTypeCompatibility { get; set; }

    public string? ReCheckOfficer { get; set; }

    public string? Notes { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
