using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AVCQueue
{
    public int QueueID { get; set; }

    public string? RegistrationNo { get; set; }

    public string? InitialNo { get; set; }

    public string? ParamedicID { get; set; }

    public int? CounterID { get; set; }

    public int? QueueNo { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public DateTime? ReadyTime { get; set; }

    public DateTime? HoldTime { get; set; }

    public DateTime? CallTime { get; set; }

    public DateTime? FinishCallTime { get; set; }

    public DateTime? FinishServiceTime { get; set; }

    public int? CallCount { get; set; }

    public string? NextCounterID { get; set; }

    public string? Notes { get; set; }

    public string? GroupID { get; set; }

    public string? SRLantai { get; set; }

    public TimeOnly? MulaiPraktik { get; set; }

    public TimeOnly? SelesaiPraktik { get; set; }
}
