using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 衛生管理人員查核_專案清單
{
    public int 主鍵 { get; set; }

    public int 衛生管理人員查核主表_主鍵 { get; set; }

    public int 專案代碼 { get; set; }
}
