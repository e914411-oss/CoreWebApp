using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_查驗登記產品查核主表
{
    public int 主鍵 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public string? 專案名稱 { get; set; }
}
