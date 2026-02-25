using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒速報主檔
{
    public int 中毒速報ID { get; set; }

    public string? 案件編號 { get; set; }

    public string? 主辦縣市 { get; set; }

    public string? 協辦縣市 { get; set; }

    public string? 通報單位 { get; set; }

    public string? 攝食團體 { get; set; }

    public string? 案件名稱 { get; set; }

    public string? 攝食時間 { get; set; }

    public string? 發病時間 { get; set; }

    public string? 通報時間 { get; set; }

    public string? 潛伏期起 { get; set; }

    public string? 潛伏期迄 { get; set; }

    public string? 攝食地點縣市鄉鎮市區 { get; set; }

    public string? 攝食地點 { get; set; }

    public string? 食品供應商名稱 { get; set; }

    public string? 食品供應商地址 { get; set; }

    public int? 攝食人數 { get; set; }

    public int? 中毒人數 { get; set; }

    public int? 就醫人數 { get; set; }

    public int? 死亡人數 { get; set; }

    public string? 處置 { get; set; }

    public string? 病因物質1 { get; set; }

    public string? 病因物質2 { get; set; }

    public string? 原因食品 { get; set; }

    public string? 污染場所 { get; set; }

    public string? 攝食場所類別 { get; set; }

    public string? 處置結果登錄日期 { get; set; }
}
