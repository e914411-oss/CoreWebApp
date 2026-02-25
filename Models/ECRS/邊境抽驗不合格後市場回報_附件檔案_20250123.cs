using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 邊境抽驗不合格後市場回報_附件檔案_20250123
{
    public int 主鍵 { get; set; }

    public int? 主案主鍵 { get; set; }

    public string? 案件階層 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 上傳人員 { get; set; }

    public string? 檔案名稱 { get; set; }

    public string? 檔案格式 { get; set; }

    public byte[]? 檔案內容 { get; set; }
}
