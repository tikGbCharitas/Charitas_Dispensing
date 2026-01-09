using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AVCCounter
{
    public int CounterID { get; set; }

    public string? CounterName { get; set; }

    public string? CounterType { get; set; }

    public string? SRFloor { get; set; }

    public string? ServiceUnitID { get; set; }

    public string? ComputerID { get; set; }

    public string? ComputerIP { get; set; }

    public bool? IsStartService { get; set; }

    public string? ParamedicID { get; set; }

    public string? UserID { get; set; }

    public string? ScannerTemplateID { get; set; }

    public string? GroupID { get; set; }

    public bool? IsEmergency { get; set; }

    public TimeOnly? StartTimeCounter { get; set; }

    public string? Notes { get; set; }

    public string? PrinterName { get; set; }

    public string? Title { get; set; }

    public string? AdditionalCounterID { get; set; }
}
