using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處專區_論述經驗
{
    public int 主鍵 { get; set; }

    public string? 本署發文字號 { get; set; }

    public string? 案件屬性 { get; set; }

    public string? 主旨 { get; set; }

    public string? 處辦爭議理由 { get; set; }

    public string? 修正建議 { get; set; }

    public string? 區管回應處至內容 { get; set; }

    public string? 注意事項 { get; set; }

    public string? 關鍵字1 { get; set; }

    public string? 關鍵字2 { get; set; }

    public string? 關鍵字3 { get; set; }

    public string? 關鍵字4 { get; set; }

    public string? 關鍵字5 { get; set; }

    public string? 承辦人 { get; set; }

    public string 來文或移案字號 { get; set; } = null!;

    public string? 類別 { get; set; }

    public string? 業者名稱 { get; set; }

    public string? 生產國別 { get; set; }

    public string? 產品 { get; set; }

    public string? 備註 { get; set; }

    public DateTime? 分案日期 { get; set; }

    public string? 辦理情形 { get; set; }

    public string? 案件狀態 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 異動人員 { get; set; }

    public DateTime? 異動日期 { get; set; }
}
