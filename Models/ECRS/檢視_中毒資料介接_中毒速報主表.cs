using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_中毒資料介接_中毒速報主表
{
    public int 前端案件編號 { get; set; }

    public string 案由 { get; set; } = null!;

    public string? 攝食日期 { get; set; }

    public string 案件縣市代碼 { get; set; } = null!;

    public string? 案件處理狀態 { get; set; }

    public string 案件縣市名稱 { get; set; } = null!;

    public string 攝食地點名稱 { get; set; } = null!;

    public string 攝食地點郵遞區號名稱 { get; set; } = null!;

    public string 攝食地點郵遞區號 { get; set; } = null!;

    public string 攝食地點地址 { get; set; } = null!;

    public string? 發病日期 { get; set; }

    public string 發病地點 { get; set; } = null!;

    public string? 受理日期 { get; set; }

    public string 受理人員姓名 { get; set; } = null!;

    public string? 受理人員電話區碼 { get; set; }

    public string 受理人員電話 { get; set; } = null!;

    public string 受理人員分機 { get; set; } = null!;

    public string? 受理人員傳真 { get; set; }

    public string? 受理人員傳真區碼 { get; set; }

    public string? 受理人員傳真分機 { get; set; }

    public int 中毒總人數 { get; set; }

    public int 攝食總人數 { get; set; }

    public string? 最小潛伏期日 { get; set; }

    public string? 最小潛伏期時 { get; set; }

    public string? 最小潛伏期分 { get; set; }

    public string? 最大潛伏期日 { get; set; }

    public string? 最大潛伏期時 { get; set; }

    public string? 最大潛伏期分 { get; set; }

    public int 死亡總人數 { get; set; }

    public string 中毒原因_細菌性 { get; set; } = null!;

    public string 中毒原因_化學性 { get; set; } = null!;

    public string 中毒原因_化學性_重金屬 { get; set; } = null!;

    public string 中毒原因_化學性_農藥 { get; set; } = null!;

    public string 中毒原因_化學性_動物用藥 { get; set; } = null!;

    public string 中毒原因_化學性_其他 { get; set; } = null!;

    public string 中毒原因_化學性_其他說明 { get; set; } = null!;

    public string 中毒原因_天然毒 { get; set; } = null!;

    public string 中毒原因_天然毒_動物性 { get; set; } = null!;

    public string 中毒原因_天然毒_動物性說明 { get; set; } = null!;

    public string 中毒原因_天然毒_植物性 { get; set; } = null!;

    public string 中毒原因_天然毒_植物性說明 { get; set; } = null!;

    public string 中毒原因_天然毒_其他 { get; set; } = null!;

    public string 中毒原因_天然毒_其他說明 { get; set; } = null!;

    public string 中毒原因_特異體質 { get; set; } = null!;

    public string 中毒原因_特異體質說明 { get; set; } = null!;

    public string 中毒原因_其他 { get; set; } = null!;

    public string 中毒原因_其他說明 { get; set; } = null!;

    public string 導致食物腐敗原因_其他說明 { get; set; } = null!;

    public string 涉嫌食品前處理_保存時間 { get; set; } = null!;

    public int 涉嫌食品前處理_保存溫度 { get; set; }

    public string 涉嫌食品前處理_送達時間 { get; set; } = null!;

    public string 食品來源調理情形 { get; set; } = null!;

    public string 涉嫌食品處理代碼 { get; set; } = null!;

    public string? 涉嫌食品處理_其他說明 { get; set; }

    public string 攝食場所類別_其他說明 { get; set; } = null!;

    public string 案情簡述 { get; set; } = null!;

    public string? 創建人員ID { get; set; }

    public string? 建立時間 { get; set; }

    public string? 創建人員_名字 { get; set; }

    public string? 創建人員_縣市 { get; set; }
}
