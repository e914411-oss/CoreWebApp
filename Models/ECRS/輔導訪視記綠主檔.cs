using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輔導訪視記綠主檔
{
    public int 輔導記錄主檔編號 { get; set; }

    public string? 公司名稱 { get; set; }

    public string? 工廠名稱 { get; set; }

    public string? 工廠地址 { get; set; }

    public string? 食品業者登錄字號 { get; set; }

    public string? 縣市名稱 { get; set; }

    public string? 縣市編號 { get; set; }

    public DateOnly? 輔導日期 { get; set; }

    public string? 輔導種類 { get; set; }

    public int? 輔導年度 { get; set; }

    public string? 分級結果 { get; set; }
}
