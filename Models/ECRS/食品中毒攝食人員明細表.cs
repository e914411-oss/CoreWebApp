using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒攝食人員明細表
{
    /// <summary>
    /// 人員序碼
    /// </summary>
    public int 食品中毒攝食人員明細表_主鍵 { get; set; }

    /// <summary>
    /// 外部序號
    /// </summary>
    public int? FMS介接主鍵 { get; set; }

    /// <summary>
    /// 中毒速報序號
    /// </summary>
    public int? 食品中毒速報主表主鍵 { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public string? 攝食人員姓名 { get; set; }

    /// <summary>
    /// 性別 男/女
    /// </summary>
    public string? 攝食人員性別 { get; set; }

    /// <summary>
    /// 年齡
    /// </summary>
    public int? 攝食人員年齡 { get; set; }

    /// <summary>
    /// 生日
    /// </summary>
    public DateOnly? 攝食人員生日 { get; set; }

    /// <summary>
    /// 生日民國年月日(0800912)
    /// </summary>
    public string? 攝食人員國曆生日 { get; set; }

    /// <summary>
    /// 電話區碼
    /// </summary>
    public string? 攝食人員電話區碼 { get; set; }

    /// <summary>
    /// 電話
    /// </summary>
    public string? 攝食人員電話號碼 { get; set; }

    /// <summary>
    /// 電話分機
    /// </summary>
    public string? 攝食人員分機 { get; set; }

    /// <summary>
    /// 手機
    /// </summary>
    public string? 攝食人員手機 { get; set; }

    /// <summary>
    /// 職業代碼
    /// </summary>
    public string? 攝食人員職業代碼 { get; set; }

    /// <summary>
    /// 職業名稱
    /// </summary>
    public string? 攝食人員職業名 { get; set; }

    /// <summary>
    /// 攝食日期時間
    /// </summary>
    public DateTime? 攝食日期 { get; set; }

    /// <summary>
    /// 攝食日期民國年月日
    /// </summary>
    public string? 國曆攝食日期 { get; set; }

    /// <summary>
    /// 攝食時間
    /// </summary>
    public string? 攝食日期時分 { get; set; }

    /// <summary>
    /// 發病日期時間
    /// </summary>
    public DateTime? 發病日期 { get; set; }

    /// <summary>
    /// 發病日期民國年月日
    /// </summary>
    public string? 國曆發病日期 { get; set; }

    /// <summary>
    /// 發病時間
    /// </summary>
    public string? 發病日期時分 { get; set; }

    /// <summary>
    /// 是否死亡
    /// </summary>
    public string? 是否死亡 { get; set; }

    /// <summary>
    /// 就醫類別
    /// </summary>
    public string? 就醫類別 { get; set; }

    /// <summary>
    /// 就醫診所
    /// </summary>
    public string? 就醫地點 { get; set; }

    /// <summary>
    /// 攝食食品,多筆用逗號分隔
    /// </summary>
    public string? 攝食食品 { get; set; }

    /// <summary>
    /// 發生症狀,多筆用逗號分隔
    /// </summary>
    public string? 發生症狀 { get; set; }

    /// <summary>
    /// 身分證字號
    /// </summary>
    public string? 身分證字號 { get; set; }

    /// <summary>
    /// 住址(縣市)
    /// </summary>
    public string? 居住城市 { get; set; }

    /// <summary>
    /// 住址
    /// </summary>
    public string? 居住地址 { get; set; }

    /// <summary>
    /// 就醫日期時間
    /// </summary>
    public DateTime? 就醫日期 { get; set; }

    /// <summary>
    /// 就醫日期民國年月日
    /// </summary>
    public string? 國曆就醫日期 { get; set; }

    /// <summary>
    /// 就醫時間
    /// </summary>
    public string? 就醫日期時分 { get; set; }

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

    public string? 修改人員 { get; set; }
}
