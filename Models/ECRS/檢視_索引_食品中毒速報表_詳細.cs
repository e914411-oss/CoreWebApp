using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_食品中毒速報表_詳細
{
    public int 食品中毒速報主表主鍵 { get; set; }

    public string? 案件編號 { get; set; }

    public int? FMS介接主鍵 { get; set; }

    public string? 縣市主鍵 { get; set; }

    public string? 食餘檢體 { get; set; }

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

    public int? 供應商代碼 { get; set; }

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

    public string? 通報日期_索引 { get; set; }

    public string? 通報日期_顯示 { get; set; }

    public string? 攝食日期_索引 { get; set; }

    public string? 攝食日期民國日 { get; set; }

    public string? 攝食日期_顯示 { get; set; }

    public DateTime? 攝食日期 { get; set; }

    public string 攝食場所名稱 { get; set; } = null!;

    public string 攝食地點_縣市 { get; set; } = null!;

    public string 攝食地點_縣市郵遞區號 { get; set; } = null!;

    public string? 攝食地點_地址 { get; set; }

    public string 攝食場所類別代碼名稱 { get; set; } = null!;

    public string? 攝食場所類別_其他說明 { get; set; }

    public string? 食品供應商 { get; set; }

    public string? 食品供應商地址 { get; set; }

    public string 攝食場所所屬縣市 { get; set; } = null!;

    public string 攝食場所郵遞區名 { get; set; } = null!;

    public string 食品處置結果 { get; set; } = null!;

    public string 食品 { get; set; } = null!;

    public string 症狀 { get; set; } = null!;

    public string 導致食物腐敗原因名稱 { get; set; } = null!;

    public string? 中毒原因_化學性_名稱 { get; set; }

    public string? 中毒原因_化學性_重金屬_名稱 { get; set; }

    public string? 中毒原因_化學性_農藥_名稱 { get; set; }

    public string? 中毒原因_化學性_動物用藥_名稱 { get; set; }

    public string? 中毒原因_化學性_其他_名稱 { get; set; }

    public string? 中毒原因_天然毒_名稱 { get; set; }

    public string 中毒原因_天然毒_動物性_名稱 { get; set; } = null!;

    public string 中毒原因_天然毒_植物性_名稱 { get; set; } = null!;

    public string 中毒原因_天然毒_其他_名稱 { get; set; } = null!;

    public string 中毒原因_特異體質_名稱 { get; set; } = null!;

    public string 中毒原因_其他_名稱 { get; set; } = null!;

    public string 中毒原因_細菌性細項_名稱 { get; set; } = null!;

    public int 索引Id { get; set; }

    public string? 索引名稱 { get; set; }

    public string? 食品前次保存紀錄 { get; set; }

    public string? 潛伏期_顯示 { get; set; }

    public string? 中毒原因_顯示 { get; set; }

    public string? 導致食物腐敗原因_顯示 { get; set; }

    public string 攝食地點_顯示 { get; set; } = null!;

    public string? 通報衛生局 { get; set; }

    public string? 攝食場所類別_顯示 { get; set; }

    public int? 就醫人數 { get; set; }

    public int? 學校供餐類型 { get; set; }

    public string? 學校供餐類型_其他說明 { get; set; }

    public int? 是否為網購食品 { get; set; }

    public string? 是否透過美食外送平台送餐 { get; set; }

    public int? 共食前是否有腸胃道症狀 { get; set; }

    public string? 患者是否皆為同班 { get; set; }

    public int? 供應廠商當日總供餐量 { get; set; }

    public double? 供應廠商至學校之路程 { get; set; }

    public string? 學制 { get; set; }
}
