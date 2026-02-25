using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視表_檢驗系統檢驗項目代碼表
{
    public Guid 檢驗系統_檢驗項目主鍵 { get; set; }

    public string 檢驗系統_檢驗項目編號 { get; set; } = null!;

    public string 檢驗系統_主分類名稱 { get; set; } = null!;

    public string? 檢驗系統_次分類名稱 { get; set; }

    public string? 檢驗系統_分類名稱 { get; set; }

    public string 檢驗系統_檢驗項目名稱 { get; set; } = null!;

    public byte 是否停用 { get; set; }

    public DateTime 建立時間 { get; set; }
}
