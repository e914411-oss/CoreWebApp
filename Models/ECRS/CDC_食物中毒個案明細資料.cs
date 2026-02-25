using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class CDC_食物中毒個案明細資料
{
    public int PMDS明細主鍵 { get; set; }

    public string 食物中毒速報單編號 { get; set; } = null!;

    public string 傳染病報告單電腦編號 { get; set; } = null!;

    public string BarCode編號 { get; set; } = null!;

    public string 通報疾病 { get; set; } = null!;

    public int? 個案來源 { get; set; }

    public string? 通報醫療院所名稱 { get; set; }

    public string? 送驗單位 { get; set; }

    public int? 檢驗單位類別 { get; set; }

    public string? 檢驗單位 { get; set; }

    public string? 姓名 { get; set; }

    public string? 被採檢者個人姓名 { get; set; }

    public string? 被採檢者國籍 { get; set; }

    public DateOnly? 被採檢者生日 { get; set; }

    public string? 被採檢者性別 { get; set; }

    public string? 被採檢者病症 { get; set; }

    public string? 被採檢者住院情況 { get; set; }

    public DateOnly? 被採檢者發病日期 { get; set; }

    public DateOnly? 檢體採檢日期 { get; set; }

    public int? 檢體種類 { get; set; }

    public int? 綜合檢驗結果 { get; set; }

    public string? 病原體檢驗方法 { get; set; }

    public string? 病原體檢驗結果 { get; set; }

    public DateOnly? 上一次變更日期 { get; set; }

    public int? 刪除註記 { get; set; }

    public string? 主要症狀List { get; set; }

    public string? 其他症狀 { get; set; }

    public string? 被採檢者類型 { get; set; }

    public string? 轉入檔案名稱 { get; set; }

    public string? 是否為PMDS攝食人員 { get; set; }

    public string? 病原體大類 { get; set; }

    public string? 病原體細類 { get; set; }

    public string? 病原體次分型 { get; set; }
}
