using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SehatQBatch
{
    public string Nomorinvoice { get; set; } = null!;

    public string? Nomorbatch { get; set; }

    public string? Kodeprovider { get; set; }

    public string? Namaprovider { get; set; }

    public DateTime? Tanggalinvoice { get; set; }

    public decimal? Jumlahkasus { get; set; }

    public decimal? Totalinvoice { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }
}
