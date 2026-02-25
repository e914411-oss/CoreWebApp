using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_待審資料_20250318
{
    public int 主鍵 { get; set; }

    public DateTime? 申請時間 { get; set; }

    public string? 人員主鍵 { get; set; }

    public string? 人員中文名稱 { get; set; }

    public string? 人員電話 { get; set; }

    public string? 電子信箱 { get; set; }

    public string? 生日 { get; set; }

    public string? 醫院代碼 { get; set; }

    public string? 部門代碼 { get; set; }

    public string? 標題 { get; set; }

    public string? 郵政編號 { get; set; }

    public string? 郵政地址 { get; set; }

    public string? 傳真號碼 { get; set; }

    public string? 部門名稱 { get; set; }

    public string? 手機號碼 { get; set; }

    public string? 申請類別 { get; set; }

    public string? 申請人員 { get; set; }

    public short? 審核狀態 { get; set; }

    public short? 審核結果 { get; set; }

    public DateTime? 審核時間 { get; set; }

    public string? 審核人員 { get; set; }

    public string? Token主鍵 { get; set; }

    public string? 申請來源 { get; set; }

    public string? SSO案例編號 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 備註 { get; set; }

    public string? 角色 { get; set; }

    public string? 申請XML { get; set; }

    public string? 確認XML已發送 { get; set; }

    public string? 確認XML已取得 { get; set; }

    public string? 登入使用者主鍵 { get; set; }

    public string? 登入使用者身份 { get; set; }

    public string? 登入使用者單位 { get; set; }

    public string? 登入使用者部門 { get; set; }

    public string? 移入案件派案登記桌權限 { get; set; }

    public string? 業者審核人員權限 { get; set; }

    public string? 複查案件派案登記桌權限 { get; set; }
}
