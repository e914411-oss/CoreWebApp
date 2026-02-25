using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_中毒資料介接_中毒人員_攝食食品_Out
{
    public int? 前端案件編號 { get; set; }

    public int FMS介接主鍵 { get; set; }

    public int? 中毒攝食人員明細表_FMS介接主鍵 { get; set; }

    public int 中毒攝食人員明細表_自動編號 { get; set; }

    public string 攝食食品代碼 { get; set; } = null!;

    public string? Meal0 { get; set; }

    public string? Meal1 { get; set; }

    public string? Meal2 { get; set; }

    public string? Meal3 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 建立時間 { get; set; }

    public string? 創建人員ID { get; set; }

    public string? 創建人員_名字 { get; set; }
}
