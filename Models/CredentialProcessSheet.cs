using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class CredentialProcessSheet
{
    public string TransactionNo { get; set; } = null!;

    public int QuestionnaireItemID { get; set; }

    public string? SRCurrentAbility { get; set; }

    public string? SRRecomendation { get; set; }

    public bool? IsRequested { get; set; }

    public bool? IsReduced { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? SRRecommendationByCommittee { get; set; }

    public string? SRApprovalByDirector { get; set; }
}
