using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 邊境抽驗不合格後市場回報_稽查結果代碼
{
    public short 主鍵 { get; set; }

    public string? 稽查結果_代碼 { get; set; }

    public string? 稽查結果_文字 { get; set; }

    public short? 優先順序 { get; set; }

    public string? 是否啟用 { get; set; }
}
