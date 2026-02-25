using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_使用者對應檔
{
    public string 使用者流水號 { get; set; } = null!;

    public string 使用者帳號 { get; set; } = null!;

    public string 密碼 { get; set; } = null!;

    public string 帳號狀態 { get; set; } = null!;

    public DateTime? 密碼到期日 { get; set; }

    public string 使用者名稱 { get; set; } = null!;

    public string 性別 { get; set; } = null!;

    public string 身分證字號 { get; set; } = null!;

    public string 電話 { get; set; } = null!;

    public string? 手機號碼 { get; set; }

    public string 辦公所屬區域 { get; set; } = null!;

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }

    public string 角色代號 { get; set; } = null!;

    public int? 排序 { get; set; }
}
