using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_查驗登記產品_工廠
{
    public string? 製造廠代碼 { get; set; }

    public string? 國內製造廠代碼 { get; set; }

    public string? 健康食品名稱中文 { get; set; }

    public string? 許可證字號 { get; set; }

    public int 健康食品主鍵 { get; set; }

    public string? 產品類型大項 { get; set; }

    public string? 文號 { get; set; }

    public DateOnly? 有效日期 { get; set; }

    public string? 工廠登記證號 { get; set; }
}
