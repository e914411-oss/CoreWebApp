using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP稽查專案表
{
    public int 主鍵 { get; set; }

    public int? HACCP稽查主表主鍵 { get; set; }

    public int? 專案名稱主鍵 { get; set; }
}
