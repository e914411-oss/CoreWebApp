using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 醫院通報專區_醫院通報案件主表
{
    /// <summary>
    /// 系統自動產生
    /// </summary>
    public int 醫院通報案件主表_主鍵 { get; set; }

    /// <summary>
    /// HPN+西園年月日HPN + 西園年月日 + 五位數(每天案件數以00001開頭做增加)，由系統自動產生(EX.HPN2025091100001)
    /// </summary>
    public string 通報案件編號 { get; set; } = null!;

    /// <summary>
    /// 建立案件人員所屬醫事機構代碼 EX.5X310XXXXX
    /// </summary>
    public string 醫事機構代碼 { get; set; } = null!;

    /// <summary>
    /// 建立案件人員所屬醫療院所全名 EX.財團法人馬偕紀念醫院
    /// </summary>
    public string 醫療院所名稱_全名 { get; set; } = null!;

    /// <summary>
    /// 醫療院所所在縣市編號，關聯 [PMDS].[dbo].[縣市代碼表]
    /// </summary>
    public string 醫療院所所在縣市編號 { get; set; } = null!;

    /// <summary>
    /// 就醫日期時間 EX.2012-05-12 18:30:00.000
    /// </summary>
    public DateTime 就醫日期時間 { get; set; }

    /// <summary>
    /// 國曆就醫日期 EX.1141227
    /// </summary>
    public string 國曆就醫日期 { get; set; } = null!;

    /// <summary>
    /// 發病日期 EX.2012-05-12 18:30:00.000
    /// </summary>
    public DateTime 發病日期 { get; set; }

    /// <summary>
    /// 國曆發病日期 EX.1141227
    /// </summary>
    public string 國曆發病日期 { get; set; } = null!;

    /// <summary>
    /// 發病地點 (家中、辦公室、餐廳)
    /// </summary>
    public string? 發病地點 { get; set; }

    /// <summary>
    /// 攝食人數
    /// </summary>
    public string 攝食人數 { get; set; } = null!;

    /// <summary>
    /// 中毒人數
    /// </summary>
    public string 中毒人數 { get; set; } = null!;

    /// <summary>
    /// 就醫人數
    /// </summary>
    public string 就醫人數 { get; set; } = null!;

    /// <summary>
    /// 攝食場所名稱 (參考食品中毒攝食場所明細表)
    /// </summary>
    public string 攝食場所名稱 { get; set; } = null!;

    /// <summary>
    /// 攝食地點縣市 (參考食品中毒攝食場所明細表)
    /// </summary>
    public string 攝食地點_縣市 { get; set; } = null!;

    /// <summary>
    /// 攝食地點地址 (參考食品中毒攝食場所明細表)
    /// </summary>
    public string 攝食地點_地址 { get; set; } = null!;

    /// <summary>
    /// 攝食日期時間 EX.2012-05-12 18:30:00.000
    /// </summary>
    public DateTime 攝食日期時間 { get; set; }

    /// <summary>
    /// 國曆攝食日期 EX.1141227
    /// </summary>
    public string 國曆攝食日期 { get; set; } = null!;

    /// <summary>
    /// 建立時間，新增時 = GETDATE()
    /// </summary>
    public DateTime 建立時間 { get; set; }

    /// <summary>
    /// 修改時間，新增=建立時間，更新=當前時間
    /// </summary>
    public DateTime 修改時間 { get; set; }

    /// <summary>
    /// 刪除時間
    /// </summary>
    public DateTime? 刪除時間 { get; set; }

    /// <summary>
    /// 建立人員=醫院通報專區_使用者基本資料表.使用者帳號
    /// </summary>
    public string 建立人員 { get; set; } = null!;

    /// <summary>
    /// 修改人員，新增=建立人員，更新=修改者帳號
    /// </summary>
    public string 修改人員 { get; set; } = null!;

    /// <summary>
    /// 刪除人員
    /// </summary>
    public string? 刪除人員 { get; set; }

    /// <summary>
    /// 是否送審 (Y/N)
    /// </summary>
    public string? 是否送審 { get; set; }

    /// <summary>
    /// 是否刪除 Y or N
    /// </summary>
    public string? 是否刪除 { get; set; }

    public virtual ICollection<醫院通報專區_醫院通報攝食人員明細表> 醫院通報專區_醫院通報攝食人員明細表s { get; set; } = new List<醫院通報專區_醫院通報攝食人員明細表>();
}
