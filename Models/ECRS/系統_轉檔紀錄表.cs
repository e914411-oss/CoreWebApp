using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_轉檔紀錄表
{
    public string 資料來源類型 { get; set; } = null!;

    public string 資料來源Id { get; set; } = null!;

    public string? 資料來源名稱 { get; set; }

    public string? 是否啟用 { get; set; }
}
