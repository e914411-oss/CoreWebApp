using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 紀錄_邊境查驗資料使用紀錄
{
    public int 主鍵 { get; set; }

    public string? 使用者帳號 { get; set; }

    public string? 使用者姓名 { get; set; }

    public DateTime? 使用當下時間 { get; set; }

    public int? 查詢成功筆數 { get; set; }

    public string? 使用者所屬縣市 { get; set; }

    public string? 使用者編號 { get; set; }

    public string? 使用目的 { get; set; }

    public DateTime? 結案日期 { get; set; }

    public string? 結案人員 { get; set; }

    public string? 使用條件 { get; set; }
}
