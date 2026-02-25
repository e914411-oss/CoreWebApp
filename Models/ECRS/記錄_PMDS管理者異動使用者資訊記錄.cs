using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_PMDS管理者異動使用者資訊記錄
{
    public string 使用者帳號 { get; set; } = null!;

    public string? 姓名 { get; set; }

    public string? 電話 { get; set; }

    public string? 分機 { get; set; }

    public string? 所屬單位機關代碼 { get; set; }

    public string? 所屬單位名稱 { get; set; }

    public string? 密碼 { get; set; }

    public string? 手機 { get; set; }

    public string? 電子郵件 { get; set; }

    public string? 職稱 { get; set; }

    public string? 是否停用 { get; set; }

    public string? 公衛之機關代碼 { get; set; }

    public string? 使用者權限 { get; set; }

    public string? 所屬科別 { get; set; }

    public int 使用者角色 { get; set; }

    public string 更新人員使用者識別碼 { get; set; } = null!;

    public string? 更新人員部門識別碼 { get; set; }

    public string? 更新人員使用者名稱 { get; set; }

    public string 更新人員使用者角色 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public int Id { get; set; }
}
