using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_食品中毒攝食人員
{
    public int 食品中毒攝食人員明細表_主鍵 { get; set; }

    public int? FMS介接主鍵 { get; set; }

    public int? 食品中毒速報主表主鍵 { get; set; }

    public string? 攝食人員姓名 { get; set; }

    public string? 攝食人員性別 { get; set; }

    public int? 攝食人員年齡 { get; set; }

    public DateOnly? 攝食人員生日 { get; set; }

    public string? 攝食人員國曆生日 { get; set; }

    public string? 攝食人員電話區碼 { get; set; }

    public string? 攝食人員電話號碼 { get; set; }

    public string? 攝食人員分機 { get; set; }

    public string? 攝食人員手機 { get; set; }

    public string? 攝食人員職業代碼 { get; set; }

    public string? 攝食人員職業名 { get; set; }

    public DateTime? 攝食日期 { get; set; }

    public string? 國曆攝食日期 { get; set; }

    public string? 攝食日期時分 { get; set; }

    public DateTime? 發病日期 { get; set; }

    public string? 國曆發病日期 { get; set; }

    public string? 發病日期時分 { get; set; }

    public string? 是否死亡 { get; set; }

    public string? 就醫類別 { get; set; }

    public string? 就醫地點 { get; set; }

    public string? 攝食食品 { get; set; }

    public string? 發生症狀 { get; set; }

    public string? 身分證字號 { get; set; }

    public string? 居住城市 { get; set; }

    public string? 居住地址 { get; set; }

    public DateTime? 就醫日期 { get; set; }

    public string? 國曆就醫日期 { get; set; }

    public string? 就醫日期時分 { get; set; }

    public string? 刪除註記 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public DateTime? 刪除時間 { get; set; }

    public string? 修改人員 { get; set; }

    public string? 攝食日期_Idx { get; set; }

    public string? 攝食日期_Show { get; set; }

    public string? 攝食人員生日_Idx { get; set; }

    public string? 攝食人員生日_Show { get; set; }

    public string? 發病日期_Idx { get; set; }

    public string? 發病日期_Show { get; set; }

    public string? 就醫日期_Idx { get; set; }

    public string? 就醫日期_Show { get; set; }

    public string? 食品 { get; set; }

    public string? 症狀 { get; set; }

    public string? 就醫類型 { get; set; }
}
