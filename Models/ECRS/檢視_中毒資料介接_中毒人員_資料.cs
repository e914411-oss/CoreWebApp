using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_中毒資料介接_中毒人員_資料
{
    public int? 前端案件編號 { get; set; }

    public int 人員序碼 { get; set; }

    public string? 攝食日期時間 { get; set; }

    public string? 攝食人員姓名 { get; set; }

    public int? 攝食人員年齡 { get; set; }

    public string? 攝食人員性別 { get; set; }

    public string? 身分證字號 { get; set; }

    public string? 攝食人員_生日 { get; set; }

    public string? 攝食人員職業代碼 { get; set; }

    public string? 攝食人員職業名 { get; set; }

    public string? 攝食人員電話區碼 { get; set; }

    public string? 攝食人員分機 { get; set; }

    public string? 攝食人員電話號碼 { get; set; }

    public string? 攝食人員手機 { get; set; }

    public string? 居住城市 { get; set; }

    public string? 攝食人員_郵遞區號名稱 { get; set; }

    public string? 居住地址 { get; set; }

    public string? 是否發病 { get; set; }

    public string? 發病日期時間 { get; set; }

    public string? 是否就醫 { get; set; }

    public string? 是否死亡 { get; set; }

    public string? 就醫類別 { get; set; }

    public string? 就醫地點 { get; set; }

    public string? 潛汏期 { get; set; }

    public string? 餐別 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 建立之縣市 { get; set; }

    public string? 建立之日期時間 { get; set; }

    public string? 建立之使用者代碼 { get; set; }

    public string? 建立之使用者姓名 { get; set; }

    public int FMS介接主鍵 { get; set; }
}
