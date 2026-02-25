using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒陳判單
{
    public int 食品中毒陳判單_主鍵 { get; set; }

    public int? 食品中毒速報主表主鍵 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    public string? 陳判日期 { get; set; }

    public string? 本案非食品中毒案件 { get; set; }

    public string? 食品供應商 { get; set; }

    public string? 發生時間 { get; set; }

    public string? 攝食人數 { get; set; }

    public string? 食品檢體 { get; set; }

    public string? 食品檢體結果 { get; set; }

    public string? 環境檢體 { get; set; }

    public string? 環境檢體結果 { get; set; }

    public string? 患者檢體 { get; set; }

    public string? 患者檢體結果 { get; set; }

    public string? 工作人員檢體 { get; set; }

    public string? 工作人員檢體結果 { get; set; }

    public string? 地點 { get; set; }

    public string? 原因食品 { get; set; }

    public string? 病因物質_不明 { get; set; }

    public string? 病因物質_腸炎弧菌血清型 { get; set; }

    public string? 原因食品描述 { get; set; }

    public bool? 本案是否非食品中毒案件 { get; set; }

    public string? 病因物質描述 { get; set; }

    public string? 備註 { get; set; }

    public string? 案件編號 { get; set; }

    public string? 原因食品2_不明 { get; set; }

    public string? 有無勾選病因物質2_不明 { get; set; }

    public string? 處置結果 { get; set; }

    public string? 攝食場所 { get; set; }

    public string? 原因食品2描述 { get; set; }

    public string? 病因物質2_不明 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public string? 更新人員 { get; set; }

    public string? 本案檢驗結果資訊 { get; set; }
}
