using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_查驗登記產品
{
    public int 健康食品主鍵 { get; set; }

    public string? 健康食品名稱中文 { get; set; }

    public string? 健康食品名稱英文 { get; set; }

    public string? 許可證字號 { get; set; }

    public string? 許可證字號代碼及號碼 { get; set; }

    public string? 申請商或國內製造廠分裝廠代碼 { get; set; }

    public string? 申請商代碼 { get; set; }

    public string? 類別碼 { get; set; }

    public string? 製造商編號 { get; set; }

    public string? 匯出1 { get; set; }

    public string? 匯出2 { get; set; }

    public string? 申請商名稱 { get; set; }

    public string? 申請商負責人 { get; set; }

    public string? 申請商電話 { get; set; }

    public string? 申請商地址 { get; set; }

    public string? 製造商名稱 { get; set; }

    public string? 製造商電話 { get; set; }

    public string? 製造商負責人 { get; set; }

    public string? 製造商地址 { get; set; }

    public string? 產品類型大項 { get; set; }

    public string? 文號 { get; set; }

    public string? 產品類型細項 { get; set; }

    public DateOnly? 申請日期 { get; set; }

    public DateOnly? 有效日期 { get; set; }
}
