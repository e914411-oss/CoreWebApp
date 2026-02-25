using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 紀錄_系統紀錄檔
{
    public int 主鍵 { get; set; }

    public string 系統名稱 { get; set; } = null!;

    public string 系統登入者 { get; set; } = null!;

    public string 資料類型 { get; set; } = null!;

    public string 訊息 { get; set; } = null!;

    public string? 內容 { get; set; }

    public DateTime 建立日期 { get; set; }
}
