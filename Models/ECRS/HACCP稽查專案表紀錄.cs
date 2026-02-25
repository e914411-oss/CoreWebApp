using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP稽查專案表紀錄
{
    public int 完成HACCP稽查主表主鍵 { get; set; }

    public DateTime 記錄日期 { get; set; }

    public int 完成主鍵 { get; set; }

    public int 主鍵 { get; set; }

    public int? HACCP稽查主表主鍵 { get; set; }

    public int? 專案名稱主鍵 { get; set; }
}
