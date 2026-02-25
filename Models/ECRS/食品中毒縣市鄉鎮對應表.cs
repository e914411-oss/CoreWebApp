using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒縣市鄉鎮對應表
{
    public string 郵遞區號 { get; set; } = null!;

    public string? 名稱 { get; set; }

    public string? 英文型別 { get; set; }

    public string? 創建人員名稱 { get; set; }

    public string? 刪除標記 { get; set; }

    public DateTime? 創建時間 { get; set; }

    public string? 創建人員ID { get; set; }

    public string 縣市代碼 { get; set; } = null!;
}
