using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_食品中毒搜尋
{
    public int 食品中毒速報主表主鍵 { get; set; }

    public int? FMS介接主鍵 { get; set; }

    public string? 縣市主鍵 { get; set; }

    public string? 縣市名稱 { get; set; }

    public DateTime? 通報日期時間 { get; set; }

    public string? 國曆通報日期 { get; set; }

    public string? 通報日期時分 { get; set; }

    public string? 通報單位 { get; set; }

    public DateTime? 受理日期 { get; set; }

    public string? 國曆受理日期 { get; set; }

    public string? 受理日期時分 { get; set; }

    public string? 案由 { get; set; }

    public int? 中毒人數 { get; set; }

    public int? 攝食人數 { get; set; }

    public int? 死亡人數 { get; set; }

    public DateTime? 發病日期 { get; set; }

    public string? 國曆發病日期 { get; set; }

    public string? 發病日期時分 { get; set; }

    public string? 發病地點 { get; set; }

    public string? 最小潛伏期時 { get; set; }

    public string? 最小潛伏期分 { get; set; }

    public string? 最大潛伏期時 { get; set; }

    public string? 最大潛伏期分 { get; set; }

    public string? 中毒原因_細菌性 { get; set; }

    public string? 中毒原因_細菌性細項 { get; set; }

    public string? 中毒原因_化學性 { get; set; }

    public string? 中毒原因_化學性_重金屬 { get; set; }

    public string? 中毒原因_化學性_農藥 { get; set; }

    public string? 中毒原因_化學性_動物用藥 { get; set; }

    public string? 中毒原因_化學性_其他 { get; set; }

    public string? 中毒原因_化學性_其他說明 { get; set; }

    public string? 中毒原因_天然毒 { get; set; }

    public string? 中毒原因_天然毒_動物性 { get; set; }

    public string? 中毒原因_天然毒_動物性說明 { get; set; }

    public string? 中毒原因_天然毒_植物性 { get; set; }

    public string? 中毒原因_天然毒_植物性說明 { get; set; }

    public string? 中毒原因_天然毒_其他 { get; set; }

    public string? 中毒原因_天然毒_其他說明 { get; set; }

    public string? 中毒原因_特異體質 { get; set; }

    public string? 中毒原因_特異體質說明 { get; set; }

    public string? 中毒原因_其他 { get; set; }

    public string? 中毒原因_其他說明 { get; set; }

    public string? 導致食物腐敗原因代碼 { get; set; }

    public string? 導致食物腐敗原因_其他說明 { get; set; }

    public string? 涉嫌食品處理代碼 { get; set; }

    public string? 涉嫌食品前處理_保存時間 { get; set; }

    public int? 涉嫌食品前處理_保存溫度 { get; set; }

    public string? 涉嫌食品前處理_送達時間 { get; set; }

    public string? 食品來源調理情形 { get; set; }

    public string? 攝食食品 { get; set; }

    public string? 發生症狀 { get; set; }

    public string? 案情簡述 { get; set; }

    public string? 檢體抽驗情形 { get; set; }

    public string? 其他報告_備註 { get; set; }

    public string? 刪除註記 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public DateTime? 刪除時間 { get; set; }

    public DateTime? 資料傳送時間 { get; set; }

    public int? 資料狀態 { get; set; }

    public string? 儲存並快訊通知 { get; set; }

    public string? 移外縣市 { get; set; }

    public string? 使用者帳號 { get; set; }

    public DateOnly? 最近稽查日期 { get; set; }

    public string? 案件編號 { get; set; }

    public string? 案件狀態 { get; set; }

    public string? 案件類別 { get; set; }

    public string? 食餘檢體 { get; set; }

    public string? 主要案件編號 { get; set; }

    public int? 原因食品_不明 { get; set; }

    public string? 原因食品 { get; set; }

    public int? 病因物質不明 { get; set; }

    public string? 病毒名稱 { get; set; }

    public string? 病因物質 { get; set; }

    public string? 食品中毒場所id { get; set; }

    public string? 無檢體 { get; set; }

    public int? 快訊次數 { get; set; }

    public DateTime? 攝食日期 { get; set; }

    public string? 攝食日期民國日 { get; set; }

    public string? 攝食日期時分 { get; set; }

    public int 索引Id { get; set; }

    public string? 索引名稱 { get; set; }

    public string? 食品供應商 { get; set; }
}
