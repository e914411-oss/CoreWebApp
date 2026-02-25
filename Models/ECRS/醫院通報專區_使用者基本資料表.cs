using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 醫院通報專區_使用者基本資料表
{
    /// <summary>
    /// 所屬醫事機構代碼
    /// </summary>
    public string 所屬醫事機構代碼 { get; set; } = null!;

    public string 所屬醫院名稱 { get; set; } = null!;

    public string 醫院所屬單位縣市編號 { get; set; } = null!;

    /// <summary>
    /// 使用者帳號
    /// </summary>
    public string 使用者帳號 { get; set; } = null!;

    /// <summary>
    /// 姓名
    /// </summary>
    public string 姓名 { get; set; } = null!;

    public string 性別 { get; set; } = null!;

    /// <summary>
    /// 密碼
    /// </summary>
    public string 密碼 { get; set; } = null!;

    public string? 電話 { get; set; }

    /// <summary>
    /// 身分證字號
    /// </summary>
    public string 身分證字號 { get; set; } = null!;

    public string? 分機 { get; set; }

    public string? 所屬單位 { get; set; }

    public string? 行動電話 { get; set; }

    public string? 傳真 { get; set; }

    public string? 電子郵件 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 修改時間 { get; set; }

    /// <summary>
    /// 是否送審 (Y/N)
    /// </summary>
    public string? 是否送審 { get; set; }

    public string 帳號審核人員_使用者帳號 { get; set; } = null!;

    public string? 帳號審核人員_姓名 { get; set; }

    public string 帳號審核人員_所屬單位縣市編號 { get; set; } = null!;

    public string 帳號審核人員_所屬單位名稱 { get; set; } = null!;

    public string? 帳號狀態 { get; set; }

    public DateTime? 帳號開通時間 { get; set; }

    public int? 是否需強制變更密碼 { get; set; }

    public DateTime? 前次更換密碼時間 { get; set; }

    public int? 登入錯誤次數 { get; set; }

    public DateTime? 上次登入錯誤時間 { get; set; }

    public string? 建立人員 { get; set; }

    public string? 更新人員 { get; set; }

    public DateTime? 最近一次登入時間 { get; set; }

    public string? 註解 { get; set; }

    public DateTime? 送審時間 { get; set; }

    public string? 是否刪除 { get; set; }
}
