using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 專案檔案表
{
    public int 專案檔案表主鍵 { get; set; }

    public int? 專案名稱代碼表主鍵 { get; set; }

    public string? 檔案名稱 { get; set; }

    public byte[]? 檔案日期 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 異動日期 { get; set; }
}
