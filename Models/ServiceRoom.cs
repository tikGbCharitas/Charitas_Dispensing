using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class ServiceRoom
{
    public string RoomID { get; set; } = null!;

    public string ServiceUnitID { get; set; } = null!;

    public string RoomName { get; set; } = null!;

    public string ItemID { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool? IsOperatingRoom { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }

    public string? ParamedicID1 { get; set; }

    public string? ParamedicID2 { get; set; }

    public short? NumberOfBeds { get; set; }

    public string? ItemBookedID { get; set; }

    public decimal? TariffDiscountForRoomIn { get; set; }

    public string? SRFloor { get; set; }

    public bool? IsBpjs { get; set; }

    public string? SRGenderType { get; set; }

    public virtual ICollection<ServiceUnitBooking> ServiceUnitBookings { get; set; } = new List<ServiceUnitBooking>();
}
