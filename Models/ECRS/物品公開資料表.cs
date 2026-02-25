using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品公開資料表
{
    public int 物品公開編號 { get; set; }

    public string? 類別 { get; set; }

    public int? 類別編號 { get; set; }

    public string? 公開類型 { get; set; }

    public string? 是否完成確認 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 縣市 { get; set; }

    public DateTime? 確認時間 { get; set; }
}
