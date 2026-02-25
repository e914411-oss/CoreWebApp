using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品回收後續處理稽查主檔
{
    public int 化粧品回收處理序號 { get; set; }

    public int 稽查序號 { get; set; }

    public int 回收主檔代碼 { get; set; }

    public int 專案代碼 { get; set; }

    public int 系統識別碼 { get; set; }

    public string? 負責衛生局代碼 { get; set; }

    public string? 數量是否相符 { get; set; }

    public string? 數量不符理由 { get; set; }

    public DateOnly? 查核日期 { get; set; }

    public string? 衛生局聯絡窗口 { get; set; }

    public string? 衛生局聯絡電話 { get; set; }

    public string? 目前執行人員 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查人員 { get; set; }

    public string? 流程階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateOnly? 結案日期 { get; set; }

    public string? QMS已結案 { get; set; }

    public DateTime 新增時間 { get; set; }

    public string? 新增人員 { get; set; }

    public DateTime 更新時間 { get; set; }

    public string? 更新人員 { get; set; }

    public string? 衛生局主鍵 { get; set; }
}
