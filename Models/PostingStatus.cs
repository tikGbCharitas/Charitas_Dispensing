using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class PostingStatus
{
    public int PostingId { get; set; }

    public string Month { get; set; } = null!;

    public string Year { get; set; } = null!;

    public bool IsEnabled { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string LastUpdateByUserID { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public DateOnly? PostingUntilDate { get; set; }

    public int? JournalSummaryId { get; set; }

    public bool? isFiscalYear { get; set; }

    public bool? isUncompleteAppr { get; set; }

    public int? JournalGroupID { get; set; }

    public bool? IsConsolidation { get; set; }

    public int? ConsolidationJournalID { get; set; }
}
