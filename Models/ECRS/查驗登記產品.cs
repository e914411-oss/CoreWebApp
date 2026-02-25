using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品
{
    public int 主鍵 { get; set; }

    public string? 許可證字號 { get; set; }

    public string? 查驗登記產品中文名稱 { get; set; }

    public string? 申請商名稱 { get; set; }

    public string? 申請商編號 { get; set; }

    public string? 申請商電話 { get; set; }

    public string? 申請商負責人 { get; set; }

    public string? 申請商地址 { get; set; }

    public string? 製造商名稱 { get; set; }

    public string? 製造商編號 { get; set; }

    public string? 製造商電話 { get; set; }

    public string? 製造商負責人 { get; set; }

    public string? 製造商地址 { get; set; }

    public string? 刪除 { get; set; }
}
