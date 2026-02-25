using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案_通路藥品回收稽查主表
{
    public int 通路藥品回收主表編號 { get; set; }

    public int? 專案代碼 { get; set; }

    public DateOnly? 發文日期 { get; set; }

    public string? 發文字號 { get; set; }

    public string? 回收藥品品名 { get; set; }

    public string? 回收藥品之許可證字號 { get; set; }

    public string? 回收批號 { get; set; }

    public string? 許可證持有者 { get; set; }

    public string? 製造廠 { get; set; }

    public string? 回收原因 { get; set; }

    public string? 建立人員 { get; set; }

    public string? 異動人員 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public int? QMS藥品回收主檔編號 { get; set; }
}
