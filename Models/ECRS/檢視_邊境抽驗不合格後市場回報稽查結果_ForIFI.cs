using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_邊境抽驗不合格後市場回報稽查結果_ForIFI
{
    public int PMDS主表主鍵 { get; set; }

    public decimal 名單序號 { get; set; }

    public string 名單名稱 { get; set; } = null!;

    public decimal 案件序號 { get; set; }

    public string? 申請人中文名稱 { get; set; }

    public string? 產品中文名稱 { get; set; }

    public string? 受理日期 { get; set; }

    public string 報驗案號 { get; set; } = null!;

    public string? 實際稽查業者統編 { get; set; }

    public string? 實際稽查業者名稱 { get; set; }

    public string? 第一層稽查結果代碼 { get; set; }

    public string? 同批號產品 { get; set; }

    public string? 回報稽查結果 { get; set; }

    public DateTime? 最新異動時間 { get; set; }

    public string? 最新異動人員 { get; set; }
}
