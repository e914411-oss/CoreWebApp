using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_食品中毒速報_報告
{
    public int 食品中毒速報主表主鍵 { get; set; }

    public string? 攝食日期_顯示 { get; set; }

    public string? 縣市名稱 { get; set; }

    public string? 縣市主鍵 { get; set; }

    public string? 案由 { get; set; }

    public string? 攝食場所_顯示 { get; set; }

    public string? 攝食場所名稱 { get; set; }

    public string? 攝食場所類別_顯示 { get; set; }

    public string? 攝食日期 { get; set; }

    public string? 食品供應商 { get; set; }

    public string? 食品供應商地址 { get; set; }

    public string? 通報日期時間_顯示 { get; set; }

    public int? 攝食人數 { get; set; }

    public int? 死亡人數 { get; set; }

    public DateTime? 發病日期 { get; set; }

    public string? 發病地點 { get; set; }

    public string? 潛伏期_顯示 { get; set; }

    public string? 中毒原因_顯示 { get; set; }

    public string? 食物腐敗原因_顯示 { get; set; }

    public string? 食品前次保存紀錄 { get; set; }

    public string 食品處置結果 { get; set; } = null!;

    public string? 食品來源調理情形 { get; set; }

    public string 食品 { get; set; } = null!;

    public string 症狀 { get; set; } = null!;

    public string? 案情簡述 { get; set; }

    public int Id { get; set; }

    public string? 案件編號 { get; set; }

    public int? 就醫人數 { get; set; }

    public string? 案件狀態 { get; set; }

    public string? R_案件狀態 { get; set; }

    public string? 相關縣市代碼 { get; set; }

    public int? 食品檢體數量 { get; set; }

    public int? 患者檢體數量 { get; set; }

    public string? 主要案件編號 { get; set; }

    public string 共食前是否有腸胃道症狀 { get; set; } = null!;

    public string? 患者是否皆為同班 { get; set; }

    public string? 供應廠商當日總供餐量 { get; set; }

    public string? 供應廠商至學校之路程 { get; set; }

    public string? 學制 { get; set; }
}
