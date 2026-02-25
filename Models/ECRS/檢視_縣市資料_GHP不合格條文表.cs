using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_縣市資料_GHP不合格條文表
{
    public int 主鍵 { get; set; }

    public int? GHP稽查主表主鍵 { get; set; }

    public int? GHP條文主鍵 { get; set; }

    public string? 條文內容 { get; set; }

    public string? 是否合格 { get; set; }

    public string? 不合格備註 { get; set; }
}
