using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒速報主表
{
    /// <summary>
    /// 中毒速報序號
    /// </summary>
    public int 食品中毒速報主表主鍵 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public int? FMS介接主鍵 { get; set; }

    public string? 縣市主鍵 { get; set; }

    /// <summary>
    /// 縣市(user所在縣市)
    /// </summary>
    public string? 縣市名稱 { get; set; }

    /// <summary>
    /// 通報日期時間(秒填00) (s1)
    /// </summary>
    public DateTime? 通報日期時間 { get; set; }

    /// <summary>
    /// 通報日期民國  (s1)
    /// </summary>
    public string? 國曆通報日期 { get; set; }

    /// <summary>
    /// 通報日期時分  (s1)
    /// </summary>
    public string? 通報日期時分 { get; set; }

    /// <summary>
    /// 通報單位 (s1)
    /// </summary>
    public string? 通報單位 { get; set; }

    /// <summary>
    /// 受理日期
    /// </summary>
    public DateTime? 受理日期 { get; set; }

    /// <summary>
    /// 受理日期民國(s1)
    /// </summary>
    public string? 國曆受理日期 { get; set; }

    /// <summary>
    /// 受理日期時分  (s1)
    /// </summary>
    public string? 受理日期時分 { get; set; }

    /// <summary>
    /// 案由 (s1)
    /// </summary>
    public string? 案由 { get; set; }

    /// <summary>
    /// 中毒人數(s1 s2)
    /// </summary>
    public int? 中毒人數 { get; set; }

    /// <summary>
    /// 攝食人數(s2)
    /// </summary>
    public int? 攝食人數 { get; set; }

    /// <summary>
    /// 死亡人數(s2)
    /// </summary>
    public int? 死亡人數 { get; set; }

    /// <summary>
    /// 發病日期(s2)
    /// </summary>
    public DateTime? 發病日期 { get; set; }

    /// <summary>
    /// 發病日期民國日期(s2)
    /// </summary>
    public string? 國曆發病日期 { get; set; }

    /// <summary>
    /// 發病日期時分(s2)
    /// </summary>
    public string? 發病日期時分 { get; set; }

    /// <summary>
    /// 發病地點(s2)
    /// </summary>
    public string? 發病地點 { get; set; }

    /// <summary>
    /// 最小潛伏期時(s2)
    /// </summary>
    public string? 最小潛伏期時 { get; set; }

    /// <summary>
    /// 最小潛伏期分(s2)
    /// </summary>
    public string? 最小潛伏期分 { get; set; }

    /// <summary>
    /// 最大潛伏期時(s2)
    /// </summary>
    public string? 最大潛伏期時 { get; set; }

    /// <summary>
    /// 最大潛伏期分(s2)
    /// </summary>
    public string? 最大潛伏期分 { get; set; }

    /// <summary>
    /// 中毒原因-細菌性(s2)
    /// </summary>
    public string? 中毒原因_細菌性 { get; set; }

    /// <summary>
    /// 中毒原因-細菌性細項,多筆用逗號分隔(s2)
    /// </summary>
    public string? 中毒原因_細菌性細項 { get; set; }

    /// <summary>
    /// 中毒原因-化學性(s2)
    /// </summary>
    public string? 中毒原因_化學性 { get; set; }

    /// <summary>
    /// 中毒原因-化學性-重金屬(s2)
    /// </summary>
    public string? 中毒原因_化學性_重金屬 { get; set; }

    /// <summary>
    /// 中毒原因-化學性-農藥(s2)
    /// </summary>
    public string? 中毒原因_化學性_農藥 { get; set; }

    /// <summary>
    /// 中毒原因-化學性-動物用藥(s2)
    /// </summary>
    public string? 中毒原因_化學性_動物用藥 { get; set; }

    /// <summary>
    /// 中毒原因-化學性-其他(s2)
    /// </summary>
    public string? 中毒原因_化學性_其他 { get; set; }

    /// <summary>
    /// 中毒原因-化學性其他-說明(s2)
    /// </summary>
    public string? 中毒原因_化學性_其他說明 { get; set; }

    /// <summary>
    /// 中毒原因-天然毒(s2)
    /// </summary>
    public string? 中毒原因_天然毒 { get; set; }

    /// <summary>
    /// 中毒原因-天然毒-動物性(s2)
    /// </summary>
    public string? 中毒原因_天然毒_動物性 { get; set; }

    /// <summary>
    /// 中毒原因-天然毒-動物性說明(s2)
    /// </summary>
    public string? 中毒原因_天然毒_動物性說明 { get; set; }

    /// <summary>
    /// 中毒原因-天然毒-植物性(s2)
    /// </summary>
    public string? 中毒原因_天然毒_植物性 { get; set; }

    /// <summary>
    /// 中毒原因-天然毒-植物性說明(s2)
    /// </summary>
    public string? 中毒原因_天然毒_植物性說明 { get; set; }

    /// <summary>
    /// 中毒原因-天然毒-其他(s2)
    /// </summary>
    public string? 中毒原因_天然毒_其他 { get; set; }

    /// <summary>
    /// 中毒原因-天然毒-其他說明(s2)
    /// </summary>
    public string? 中毒原因_天然毒_其他說明 { get; set; }

    /// <summary>
    /// 中毒原因-特異體質(s2)
    /// </summary>
    public string? 中毒原因_特異體質 { get; set; }

    /// <summary>
    /// 中毒原因-特異體質說明(s2)
    /// </summary>
    public string? 中毒原因_特異體質說明 { get; set; }

    /// <summary>
    /// 中毒原因-其他(s2)
    /// </summary>
    public string? 中毒原因_其他 { get; set; }

    /// <summary>
    /// 中毒原因-其他說明(s2)
    /// </summary>
    public string? 中毒原因_其他說明 { get; set; }

    /// <summary>
    /// 導致食物腐敗原因代碼(s2)
    /// </summary>
    public string? 導致食物腐敗原因代碼 { get; set; }

    /// <summary>
    /// 導致食物腐敗原因-其他說明(s2)
    /// </summary>
    public string? 導致食物腐敗原因_其他說明 { get; set; }

    /// <summary>
    /// 涉嫌食品處理代碼(單選)(s2)
    /// </summary>
    public string? 涉嫌食品處理代碼 { get; set; }

    /// <summary>
    /// 涉嫌食品前處理-保存時間(分鐘)(s2)
    /// </summary>
    public string? 涉嫌食品前處理_保存時間 { get; set; }

    /// <summary>
    /// 涉嫌食品前處理-保存溫度(s2)
    /// </summary>
    public int? 涉嫌食品前處理_保存溫度 { get; set; }

    /// <summary>
    /// 涉嫌食品前處理-送達時間(s2)
    /// </summary>
    public string? 涉嫌食品前處理_送達時間 { get; set; }

    /// <summary>
    /// 食品來源調理情形(s2)
    /// </summary>
    public string? 食品來源調理情形 { get; set; }

    /// <summary>
    /// 攝食食品,多筆用逗號分隔(s1,s2)
    /// </summary>
    public string? 攝食食品 { get; set; }

    /// <summary>
    /// 發生症狀,多筆用逗號分隔(s1,s2)
    /// </summary>
    public string? 發生症狀 { get; set; }

    /// <summary>
    /// 案情簡述
    /// </summary>
    public string? 案情簡述 { get; set; }

    /// <summary>
    /// 檢體抽驗情形,多筆用逗號分隔(s2)
    /// </summary>
    public string? 檢體抽驗情形 { get; set; }

    /// <summary>
    /// 其他報告(備註)(s2)
    /// </summary>
    public string? 其他報告_備註 { get; set; }

    /// <summary>
    /// 刪除註記
    /// </summary>
    public string? 刪除註記 { get; set; }

    /// <summary>
    /// 建立之日期時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 修改之日期時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 刪除之日期時間
    /// </summary>
    public DateTime? 刪除時間 { get; set; }

    /// <summary>
    /// 資料傳送時間
    /// </summary>
    public DateTime? 資料傳送時間 { get; set; }

    /// <summary>
    /// 資料狀態 0:未介接 1:已上傳 2:介接後更新
    /// </summary>
    public int? 資料狀態 { get; set; }

    /// <summary>
    /// 儲存並快訊通知(0:未通知 1:已通知)
    /// </summary>
    public string? 儲存並快訊通知 { get; set; }

    public string? 移外縣市 { get; set; }

    /// <summary>
    /// 使用者帳號
    /// </summary>
    public string? 使用者帳號 { get; set; }

    public DateOnly? 最近稽查日期 { get; set; }

    public string? 案件編號 { get; set; }

    public string? 案件狀態 { get; set; }

    public string? 案件類別 { get; set; }

    public string? 食餘檢體 { get; set; }

    /// <summary>
    /// 原因食品描述
    /// </summary>
    public string? 主要案件編號 { get; set; }

    /// <summary>
    /// 原因食品不明:1=&gt;是,0=&gt;否
    /// </summary>
    public int? 原因食品_不明 { get; set; }

    public string? 原因食品 { get; set; }

    /// <summary>
    /// 病因物質不明
    /// </summary>
    public int? 病因物質不明 { get; set; }

    /// <summary>
    /// 腸炎弧菌,血清型
    /// </summary>
    public string? 病毒名稱 { get; set; }

    /// <summary>
    /// 病因物質
    /// </summary>
    public string? 病因物質 { get; set; }

    /// <summary>
    /// 攝食場所
    /// </summary>
    public string? 食品中毒場所id { get; set; }

    public string? 無檢體 { get; set; }

    public int? 快訊次數 { get; set; }

    public int? 就醫人數 { get; set; }

    public string? 供應商為攝食場所 { get; set; }

    public string? 最初_縣市主鍵 { get; set; }

    public string? 填報人員 { get; set; }

    public int? 是否為網購食品 { get; set; }

    public int? 共食前是否有腸胃道症狀 { get; set; }

    public int? 是否透過美食外送平台送餐 { get; set; }

    public string? 外送平台名稱 { get; set; }

    public string? 通報案件編號 { get; set; }

    public virtual ICollection<食品中毒業者待稽查檔> 食品中毒業者待稽查檔s { get; set; } = new List<食品中毒業者待稽查檔>();
}
