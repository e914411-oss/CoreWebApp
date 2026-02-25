using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_電台側錄案件登錄檔
{
    public string 原始檔案或母片編號 { get; set; } = null!;

    public string 側錄類型 { get; set; } = null!;

    public DateTime 節目時間 { get; set; }

    public string 電台頻道 { get; set; } = null!;

    public string 電台頻率 { get; set; } = null!;

    public string 監錄縣市 { get; set; } = null!;

    public int 總廣告則數 { get; set; }

    public int 違規則數_食品 { get; set; }

    public int 違規則數_化妝品 { get; set; }

    public int 違規則數_中藥 { get; set; }

    public int 違規則數_西藥 { get; set; }

    public int 違規則數_醫療器材 { get; set; }

    public int 違規則數_醫療廣告 { get; set; }

    public int 違規則數_一般廣告 { get; set; }

    public int 違規則數_其他 { get; set; }

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }
}
