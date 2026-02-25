using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件通報記錄_Event_Log
{
    public int Event_Log_Id { get; set; }

    public int Event_Main_Id { get; set; }

    public DateTime ModDate { get; set; }

    public string ModUser { get; set; } = null!;
}
