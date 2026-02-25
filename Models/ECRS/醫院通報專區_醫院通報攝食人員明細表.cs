using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 醫院通報專區_醫院通報攝食人員明細表
{
    /// <summary>
    /// 系統自動產生
    /// </summary>
    public int 醫院通報攝食人員明細表_主鍵 { get; set; }

    /// <summary>
    /// 關聯 [醫院通報專區_醫院通報案件主表].[醫院通報案件主表_主鍵]
    /// </summary>
    public int 醫院通報案件主表_主鍵 { get; set; }

    /// <summary>
    /// HPN + 西園年月日 + 五位數(每天案件數以00001開頭做增加)，由系統自動產生(EX.HPN2025091100001)
    /// </summary>
    public string 通報案件編號 { get; set; } = null!;

    /// <summary>
    /// 攝食人員姓名
    /// </summary>
    public string 通報_攝食人員姓名 { get; set; } = null!;

    /// <summary>
    /// 攝食人員性別
    /// </summary>
    public string 通報_攝食人員性別 { get; set; } = null!;

    /// <summary>
    /// 攝食人員年齡
    /// </summary>
    public string 通報_攝食人員年齡 { get; set; } = null!;

    /// <summary>
    /// 攝食人員生日
    /// </summary>
    public string 通報_攝食人員生日 { get; set; } = null!;

    /// <summary>
    /// 攝食人員國曆生日 EX.1141227
    /// </summary>
    public string 攝食人員國曆生日 { get; set; } = null!;

    /// <summary>
    /// 電話區碼
    /// </summary>
    public string 通報_攝食人員電話區碼 { get; set; } = null!;

    /// <summary>
    /// 電話號碼
    /// </summary>
    public string 通報_攝食人員電話號碼 { get; set; } = null!;

    /// <summary>
    /// 患者身分證字號
    /// </summary>
    public string 通報_患者身分證字號 { get; set; } = null!;

    /// <summary>
    /// 患者病歷號
    /// </summary>
    public string 通報_患者病歷號 { get; set; } = null!;

    /// <summary>
    /// 攝食日期時間 EX.2012-05-12 18:30:00.000
    /// </summary>
    public DateTime 通報_攝食日期時間 { get; set; }

    /// <summary>
    /// 攝食日期時分 (參考 食品中毒攝食人員明細表)
    /// </summary>
    public string? 通報_攝食日期時分 { get; set; }

    /// <summary>
    /// 國曆攝食日期 EX.1141227
    /// </summary>
    public string 通報_國曆攝食日期 { get; set; } = null!;

    /// <summary>
    /// 發病日期時間 EX.2012-05-12 18:30:00.000
    /// </summary>
    public DateTime 通報_發病日期時間 { get; set; }

    /// <summary>
    /// 國曆發病日期 EX.1141227
    /// </summary>
    public string 通報_國曆發病日期 { get; set; } = null!;

    /// <summary>
    /// 發病日期時分
    /// </summary>
    public string? 通報_發病日期時分 { get; set; }

    /// <summary>
    /// 就醫日期時間 EX.2012-05-12 18:30:00.000
    /// </summary>
    public DateTime 通報_就醫日期時間 { get; set; }

    /// <summary>
    /// 就醫日期時分 (參考 食品中毒攝食人員明細表)
    /// </summary>
    public string? 通報_就醫日期時分 { get; set; }

    /// <summary>
    /// 國曆就醫日期 EX.1141227
    /// </summary>
    public string 通報_國曆就醫日期 { get; set; } = null!;

    /// <summary>
    /// 患者情況代碼 (01:留觀中, 02:已返家, 03:死亡)
    /// </summary>
    public string 通報_患者情況_代碼 { get; set; } = null!;

    /// <summary>
    /// 患者情況內容 (01:留觀中, 02:已返家, 03:死亡)
    /// </summary>
    public string 通報_患者情況_內容 { get; set; } = null!;

    /// <summary>
    /// 檢體採集代碼 (01:肛門拭子, 02:嘔吐物, 03:糞便, 04:其他)
    /// </summary>
    public string 通報_檢體採集_代碼 { get; set; } = null!;

    /// <summary>
    /// 檢體採集內容
    /// </summary>
    public string 通報_檢體採集_內容 { get; set; } = null!;

    /// <summary>
    /// 檢體採集其他內容，若代碼=其他，此欄位不可為NULL
    /// </summary>
    public string? 通報_檢體採集_其他內容 { get; set; }

    /// <summary>
    /// 攝食食品 (參考 食品中毒速報主表)
    /// </summary>
    public string 攝食食品 { get; set; } = null!;

    /// <summary>
    /// 發生症狀 (參考 食品中毒速報主表)
    /// </summary>
    public string 發生症狀 { get; set; } = null!;

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime 建立時間 { get; set; }

    /// <summary>
    /// 修改時間 (新增=建立時間, 更新=當前時間)
    /// </summary>
    public DateTime 修改時間 { get; set; }

    /// <summary>
    /// 刪除時間
    /// </summary>
    public DateTime? 刪除時間 { get; set; }

    /// <summary>
    /// 建立人員 = 使用者帳號
    /// </summary>
    public string 建立人員 { get; set; } = null!;

    /// <summary>
    /// 修改人員 (新增=建立人員, 更新=修改者帳號)
    /// </summary>
    public string 修改人員 { get; set; } = null!;

    /// <summary>
    /// 刪除人員
    /// </summary>
    public string? 刪除人員 { get; set; }

    /// <summary>
    /// 是否刪除 Y or N
    /// </summary>
    public string? 是否刪除 { get; set; }

    public virtual 醫院通報專區_醫院通報案件主表 醫院通報案件主表_主鍵Navigation { get; set; } = null!;
}
