using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_系統日誌報表及帳號異動紀錄
{
    public int 系統日誌流水號 { get; set; }

    public string 使用者流水號 { get; set; } = null!;

    public string 使用者姓名 { get; set; } = null!;

    public string 組織名稱 { get; set; } = null!;

    public string IP位址 { get; set; } = null!;

    public DateTime? 功能使用起始時間 { get; set; }

    public DateTime? 功能使用結束時間 { get; set; }

    public string 使用者使用功能 { get; set; } = null!;

    public string 違規案件編號 { get; set; } = null!;

    public string 媒體類別 { get; set; } = null!;

    public string 產品名稱 { get; set; } = null!;

    public string 案件動作 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }
}
