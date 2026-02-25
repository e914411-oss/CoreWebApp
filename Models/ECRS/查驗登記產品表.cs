using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品表
{
    public int 健康食品主鍵 { get; set; }

    public string? 許可證字號代碼及號碼 { get; set; }

    public string? 健康食品名稱中文 { get; set; }

    public string? 健康食品名稱英文 { get; set; }

    public DateOnly? 申請日期 { get; set; }

    public DateOnly? 有效日期 { get; set; }

    public string? 簽審文件編號 { get; set; }

    public string? 申請商代碼 { get; set; }

    public string? 國內製造廠代碼 { get; set; }

    public string? 國內製造廠代碼2 { get; set; }

    public string? 文號 { get; set; }

    public string? 許可證字號2 { get; set; }

    public string? 產品類型大項 { get; set; }

    public string? 產品類型細項 { get; set; }

    public string? 國外代理商代碼 { get; set; }

    public string? 國外製造廠代碼 { get; set; }

    public string? 國外製造廠代碼2 { get; set; }

    public string? 分辦是已核可過的查驗登記產品 { get; set; }
}
