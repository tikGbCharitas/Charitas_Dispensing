using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class TariffComponent
{
    public string TariffComponentID { get; set; } = null!;

    public string TariffComponentName { get; set; } = null!;

    public string SRTariffComponentType { get; set; } = null!;

    /// <summary>
    /// Jika ya maka di transakasi harus diisi kode paramedic. Digunakan untuk perhitugan jasa paramedic
    /// </summary>
    public bool? IsTariffParamedic { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? Notes { get; set; }

    public bool? IsIncludeInTaxCalc { get; set; }

    public string? SRPphType { get; set; }

    public bool? IsPrintParamedicInSlip { get; set; }
}
