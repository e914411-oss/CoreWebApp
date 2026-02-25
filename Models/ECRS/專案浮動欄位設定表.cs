using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 專案浮動欄位設定表
{
    public int 專案浮動欄位設定表主鍵 { get; set; }

    public int? 專案名稱代碼表主鍵 { get; set; }

    public int? 欄位排序 { get; set; }

    public string? 欄位名稱 { get; set; }

    public string? 欄位說明 { get; set; }

    public string? 欄位類型 { get; set; }

    public string? 欄位是否必填 { get; set; }
}
