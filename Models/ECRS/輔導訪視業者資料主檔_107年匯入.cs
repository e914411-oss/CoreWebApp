using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輔導訪視業者資料主檔_107年匯入
{
    public int 輔導訪視業者編號 { get; set; }

    public string? 工廠登錄字號 { get; set; }

    public string? 工廠_製造場所名稱 { get; set; }

    public string? 工廠地址 { get; set; }

    public string? 類別 { get; set; }

    public double? 資本額_元 { get; set; }

    public bool? 是否為登錄字號 { get; set; }

    public DateTime? 匯入更新日期 { get; set; }
}
