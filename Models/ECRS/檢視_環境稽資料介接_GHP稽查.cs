using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_環境稽資料介接_GHP稽查
{
    public int? 稽查事件主鍵 { get; set; }

    public int? 衛生局主鍵 { get; set; }

    public string? 異動別 { get; set; }

    public string? 組織群 { get; set; }

    public string? 稽查序號 { get; set; }

    public string? 業者編號 { get; set; }

    public string 業別主分類 { get; set; } = null!;

    public string? 專案名稱 { get; set; }

    public string? 限定完成日期 { get; set; }

    public string? 稽查日期 { get; set; }

    public string? 稽查備註 { get; set; }

    public string? 受檢業者代表人 { get; set; }

    public string 會辦人員 { get; set; } = null!;

    public string? 複查日期 { get; set; }

    public string? 複查註記 { get; set; }

    public string? GHP稽查註記 { get; set; }

    public string? 輔導日期 { get; set; }

    public string? 處分文號 { get; set; }

    public string? 稽查事件產生來源 { get; set; }

    public string? 稽查事件刪除註記 { get; set; }

    public string? 建檔日 { get; set; }

    public string? 異動日期 { get; set; }

    public string? 異動人員身分證字號 { get; set; }

    public string? 異動人員姓名 { get; set; }

    public string? 光度_工作台面米燭光 { get; set; }

    public string? 光度_烹調台面米燭光 { get; set; }

    public string? 光度_一般區域米燭光 { get; set; }

    public string? 溫度_冷藏 { get; set; }

    public string? 溫度_凍藏 { get; set; }

    public string? 溫度_熱藏 { get; set; }

    public string? 執行衛生自主管理 { get; set; }

    public string? 執行自行檢驗 { get; set; }

    public string 廚證人數 { get; set; } = null!;

    public string 從業人員 { get; set; } = null!;

    public string? 烹飪證照丙級人數 { get; set; }

    public string? 烹飪證照乙級人數 { get; set; }

    public string? 稽查結果_合格 { get; set; }

    public string? 稽查結果_輔導改善 { get; set; }

    public string? 稽查結果_限期改善日期 { get; set; }

    public string? 稽查結果_複查合格 { get; set; }

    public string? 稽查結果_複查不合格 { get; set; }

    public string? 稽查結果_移縣市辦理 { get; set; }

    public string? 稽查結果_停廢歇業 { get; set; }

    public string? 稽查結果_罰款金額 { get; set; }

    public string? 稽查結果_移送法院處理 { get; set; }

    public string? 稽查結果_其他 { get; set; }

    public string? 稽查結果_不合格 { get; set; }

    public string 現場稽查描述 { get; set; } = null!;

    public string? 退回註記 { get; set; }

    public string? 退回原因 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查員 { get; set; }

    public string? 作業階段FMS { get; set; }

    public string? 作業人員 { get; set; }

    public string? 結案註記 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 來源群 { get; set; }
}
