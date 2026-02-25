using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Log_Control
{
    public int ID { get; set; }

    public string? DataDate { get; set; }

    public string? BatchNo { get; set; }

    public string? DataSource { get; set; }

    public int? DataCnt { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? IsTrans { get; set; }

    public DateTime? StartTime { get; set; }

    public int? S_Cnt { get; set; }

    public int? F_Cnt { get; set; }

    public DateTime? EndTime { get; set; }

    public int? Result { get; set; }

    public int? I_Cnt { get; set; }

    public int? U_Cnt { get; set; }

    public int? D_Cnt { get; set; }
}
