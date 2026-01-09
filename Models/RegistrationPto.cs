using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class RegistrationPto
{
    public string RegistrationNo { get; set; } = null!;

    public int PtoNo { get; set; }

    public DateTime? PtoDateTime { get; set; }

    public string? PtoS { get; set; }

    public string? PtoO { get; set; }

    public string? PtoA { get; set; }

    public string? PtoP { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? RoomID { get; set; }

    public string? BedID { get; set; }

    public string? PtoPrevIllnessHistory { get; set; }

    public string? PtoDiagnose { get; set; }

    public string? PtoFamHistory { get; set; }

    public string? PtoSocialHistory { get; set; }

    public string? PtoDrugsHistory { get; set; }

    public string? PtoMainComplaint { get; set; }

    public string? PtoDrugRelatedProgram { get; set; }

    public string? PtoPlanning { get; set; }

    public string? PtoCurrentDrugs { get; set; }
}
