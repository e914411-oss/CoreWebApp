using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 具結先放行_產品照片
{
    public int 主鍵 { get; set; }

    public int? ITT0008_ID { get; set; }

    public string? 全域唯一識別碼 { get; set; }

    public string? 報驗案號 { get; set; }

    public string? 異動日期 { get; set; }

    public string? 異動時間 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 檔案名稱 { get; set; }

    public string? FILENAME { get; set; }
}
