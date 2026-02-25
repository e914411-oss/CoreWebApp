using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒速報表_更改
{
    public int 食品中毒速報主表主鍵 { get; set; }

    public string? 縣市主鍵 { get; set; }

    public DateTime? 受理日期 { get; set; }

    public string? 案由 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 案件編號 { get; set; }

    public string? 案件狀態 { get; set; }

    public string? 案件類別 { get; set; }

    public string? 主要案件編號 { get; set; }

    public string? 使用者帳號 { get; set; }

    public string? 食品中毒場所id { get; set; }

    public string? 縣市名稱 { get; set; }

    public int? 協辦城市數目 { get; set; }

    public string? 相關城市代碼 { get; set; }

    public string? 供應商 { get; set; }

    public bool? 本案是否非食品中毒案件 { get; set; }

    public DateTime? 受理日期計算結案天數用 { get; set; }

    public string? 通報案件編號 { get; set; }

    public int 是否通報案件第一次編輯 { get; set; }
}
