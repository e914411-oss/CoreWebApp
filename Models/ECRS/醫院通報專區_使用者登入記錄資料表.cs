using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 醫院通報專區_使用者登入記錄資料表
{
    /// <summary>
    /// 系統自動編碼主鍵
    /// </summary>
    public decimal 主鍵 { get; set; }

    /// <summary>
    /// 使用者帳號
    /// </summary>
    public string 使用者帳號 { get; set; } = null!;

    /// <summary>
    /// 姓名
    /// </summary>
    public string 姓名 { get; set; } = null!;

    /// <summary>
    /// 所屬醫事機構代碼
    /// </summary>
    public string 所屬醫事機構代碼 { get; set; } = null!;

    /// <summary>
    /// 所屬醫院名稱
    /// </summary>
    public string 所屬醫院名稱 { get; set; } = null!;

    /// <summary>
    /// 醫院所屬單位縣市編號
    /// </summary>
    public string 醫院所屬單位縣市編號 { get; set; } = null!;

    /// <summary>
    /// 登入時間
    /// </summary>
    public DateTime 登入時間 { get; set; }
}
