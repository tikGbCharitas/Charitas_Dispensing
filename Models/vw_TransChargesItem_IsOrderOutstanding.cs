using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class vw_TransChargesItem_IsOrderOutstanding
{
    public string RegistrationNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string FromServiceUnitID { get; set; } = null!;

    public string? ToServiceUnitID { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public string? RoomID { get; set; }

    public string? BedID { get; set; }
}
