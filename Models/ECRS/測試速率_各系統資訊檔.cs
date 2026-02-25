using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 測試速率_各系統資訊檔
{
    public int 系統編號 { get; set; }

    public string? 系統名稱 { get; set; }

    public string? 系統簡稱 { get; set; }

    public string? 系統對外IP { get; set; }

    public string? 系統負責人姓名 { get; set; }

    public string? 系統負責人單位科室 { get; set; }

    public string? 系統負責人電話 { get; set; }

    public string? 系統負責人信箱 { get; set; }

    public string? 廠商聯絡人姓名 { get; set; }

    public string? 廠商聯絡人公司 { get; set; }

    public string? 廠商聯絡人電話 { get; set; }

    public string? 廠商聯絡人信箱 { get; set; }

    public string? 廠商客服電話 { get; set; }
}
