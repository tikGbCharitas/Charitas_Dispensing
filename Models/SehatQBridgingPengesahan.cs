using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SehatQBridgingPengesahan
{
    public int Id { get; set; }

    public int? SehatQBridgingId { get; set; }

    public string? SQClaimNo { get; set; }

    public string? ItemID { get; set; }

    public string? KodeSubBenefit { get; set; }

    public string? NamaSubBenefit { get; set; }

    public string? KodeBenefit { get; set; }

    public string? NamaBenefit { get; set; }

    public decimal? BiayaAju { get; set; }

    public decimal? JaminanAsuransi { get; set; }

    public decimal? JaminanPeserta { get; set; }

    public string? Keterangan { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public bool? IsVoid { get; set; }

    public string? SehatQBridgingReferenceID { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
