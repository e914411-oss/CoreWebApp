using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 使用者資料表_沒用到
{
    public string 使用者編號 { get; set; } = null!;

    public string? 姓名 { get; set; }

    public string? 電話 { get; set; }

    public string? 分機 { get; set; }

    public string? 所屬機關代碼 { get; set; }

    public string? 所屬單位名稱 { get; set; }

    public string? 所屬單位縣市 { get; set; }

    public string? 密碼 { get; set; }

    public string? 手機 { get; set; }

    public string? 電子郵件 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 修改時間 { get; set; }

    public string? 職稱 { get; set; }

    public string? SSOTokenID { get; set; }

    public string? 帳號來源 { get; set; }

    public string? 是否停用 { get; set; }

    public string? 公衛機關代碼 { get; set; }

    public int? 是否需強制變更密碼 { get; set; }

    public DateTime? 前次更換密碼時間 { get; set; }

    public string? 使用者帳號 { get; set; }

    public string? 舊使用權限 { get; set; }

    public string? 使用者權限 { get; set; }

    public string? 所屬科別 { get; set; }

    public int 使用者角色 { get; set; }

    public string? 編碼後的身分證號 { get; set; }

    public bool? 是否為隊長 { get; set; }

    public string? 區域別 { get; set; }

    public int? 登入錯誤次數 { get; set; }

    public DateTime? 上次登入錯誤時間 { get; set; }

    public string? 違規廣告_使用者編號 { get; set; }

    public string? 性別 { get; set; }

    public string? 新增人員 { get; set; }

    public string? 更新人員 { get; set; }

    public string? 違規廣告_角色編號 { get; set; }

    public int? 違規廣告_辦公所屬區域 { get; set; }

    public string? 移入案件派案登記桌權限 { get; set; }

    public string? 代施機構審核人權限 { get; set; }
}
