using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_主表
{
    public int 不合格包裝食品通報_主表_主鍵 { get; set; }

    public DateOnly? 通報日期 { get; set; }

    public string? 通報衛生局 { get; set; }

    public string? 通報原因 { get; set; }

    public string? 產品名稱 { get; set; }

    public string? 規格 { get; set; }

    public DateOnly? 製造日期 { get; set; }

    public string? 製造日期未標示 { get; set; }

    public DateOnly? 有效日期 { get; set; }

    public string? 有效日期未標示 { get; set; }

    public string? 批號 { get; set; }

    public string? 批號未標示 { get; set; }

    public string? 製造或負責廠商 { get; set; }

    public string? 結案狀態 { get; set; }
}
