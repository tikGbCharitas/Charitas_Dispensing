using System;
using System.Collections.Generic;

namespace AvicennaDispensing.Models;

public partial class AppUserGroupProgram_asli
{
    public string UserGroupID { get; set; } = null!;

    public string ProgramID { get; set; } = null!;

    public bool? IsUserGroupAddAble { get; set; }

    public bool? IsUserGroupEditAble { get; set; }

    public bool? IsUserGroupDeleteAble { get; set; }

    public bool? IsUserGroupApprovalAble { get; set; }

    public bool? IsUserGroupUnApprovalAble { get; set; }

    public bool? IsUserGroupVoidAble { get; set; }

    public bool? IsUserGroupUnVoidAble { get; set; }

    public bool? IsUserGroupExportAble { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserID { get; set; }
}
