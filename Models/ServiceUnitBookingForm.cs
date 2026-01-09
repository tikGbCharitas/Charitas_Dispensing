using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceUnitBookingForm
{
    public string BookingNo { get; set; } = null!;

    public string QuestionFormID { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserID { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
