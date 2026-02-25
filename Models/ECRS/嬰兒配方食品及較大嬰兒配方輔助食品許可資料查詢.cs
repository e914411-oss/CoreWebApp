using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 嬰兒配方食品及較大嬰兒配方輔助食品許可資料查詢
{
    public int 流水辨別碼 { get; set; }

    public string? 公司名稱 { get; set; }

    public string? 中文名稱 { get; set; }

    public string? 英文名稱 { get; set; }

    public string? 工廠 { get; set; }

    public string? 規格 { get; set; }

    public string? 其他 { get; set; }

    public string? 取得的日期 { get; set; }

    public string? 結果日期 { get; set; }

    public string? 第一次註記編號 { get; set; }

    public string? 最後一次註記編號 { get; set; }

    public string? 電話 { get; set; }

    public string? 地址 { get; set; }

    public string? 縣市 { get; set; }

    public string? 註記 { get; set; }

    public string? 圖片 { get; set; }

    public int? 狀態 { get; set; }

    public string? 類型 { get; set; }

    public string? 生產原始地 { get; set; }
}
