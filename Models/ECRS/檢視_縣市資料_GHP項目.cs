using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_縣市資料_GHP項目
{
    public int 主鍵 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    public string? 條文內容 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
