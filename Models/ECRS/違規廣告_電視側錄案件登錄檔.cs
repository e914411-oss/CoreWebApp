using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_電視側錄案件登錄檔
{
    public string 原始檔案或母片編號 { get; set; } = null!;

    public int 軌段 { get; set; }

    public DateTime 電視時間 { get; set; }

    public string 電視類別 { get; set; } = null!;

    public string 頻道名稱 { get; set; } = null!;

    public string 節目頻道 { get; set; } = null!;

    public int 總廣告則數 { get; set; }

    public int 違規則數_食品 { get; set; }

    public int 違規則數_化妝品 { get; set; }

    public int 違規則數_中藥 { get; set; }

    public int 違規則數_西藥 { get; set; }

    public int 違規則數_醫療器材 { get; set; }

    public int 違規則數_醫療廣告 { get; set; }

    public int 違規則數_一般廣告 { get; set; }

    public int 違規則數_其他 { get; set; }

    public string? 頻道業者 { get; set; }
}
