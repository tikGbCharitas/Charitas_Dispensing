using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppProgram
{
    public string ProgramID { get; set; } = null!;

    public string? ParentProgramID { get; set; }

    public string ProgramName { get; set; } = null!;

    public string? TopLevelProgramID { get; set; }

    public byte RootLevel { get; set; }

    public short RowIndex { get; set; }

    public string? Note { get; set; }

    public bool? IsParentProgram { get; set; }

    public bool? IsProgram { get; set; }

    public bool? IsBeginGroup { get; set; }

    public string? ProgramType { get; set; }

    public bool? IsProgramAddAble { get; set; }

    public bool? IsProgramEditAble { get; set; }

    public bool? IsProgramDeleteAble { get; set; }

    public bool? IsProgramViewAble { get; set; }

    public bool? IsProgramApprovalAble { get; set; }

    public bool? IsProgramUnApprovalAble { get; set; }

    public bool? IsProgramVoidAble { get; set; }

    public bool? IsProgramUnVoidAble { get; set; }

    public bool? IsProgramDirectVoid { get; set; }

    public bool? IsProgramPrintAble { get; set; }

    public bool? IsMenuAddVisible { get; set; }

    public bool? IsMenuHomeVisible { get; set; }

    public bool? IsVisible { get; set; }

    public bool IsDiscontinue { get; set; }

    public string? NavigateUrl { get; set; }

    public string? HelpLinkID { get; set; }

    public string? AssemblyName { get; set; }

    public string? AssemblyClassName { get; set; }

    public string? StoreProcedureName { get; set; }

    public string? AccessKey { get; set; }

    public bool? IsUsingReportHeader { get; set; }

    public bool? IsDirectPrintEnable { get; set; }

    public bool? IsListLoadRecordOnInit { get; set; }

    public bool? IsListLoadRecordIfFiltered { get; set; }

    public bool? IsProgramRedirected { get; set; }

    public string? ApplicationID { get; set; }

    public string? ZplCommandTemplate { get; set; }

    public bool? IsProgramExportAble { get; set; }
}
