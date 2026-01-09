using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class SehatQBatchComponent
{
    public string Nomorinvoice { get; set; } = null!;

    public string Noklaim { get; set; } = null!;

    public string? Namapeserta { get; set; }

    public DateTime? Tanggallahir { get; set; }

    public string? Nokartu { get; set; }

    public string? Nopolis { get; set; }

    public string? Nobpjs { get; set; }

    public string? Nosep { get; set; }

    public string? Nomorrujukan { get; set; }

    public string? Planid { get; set; }

    public string? Masapolis { get; set; }

    public string? Namaperusahaan { get; set; }

    public string? Namapenjamin { get; set; }

    public DateTime? Tanggalmasuk { get; set; }

    public DateTime? Tanggalkeluar { get; set; }

    public string? Namapegawai { get; set; }

    public string? Namabenefit { get; set; }

    public string? Kodediagnosa { get; set; }

    public int? Statusklaim { get; set; }

    public int? Jaminanasuransi { get; set; }

    public string? Notransaksiprovider { get; set; }
}
