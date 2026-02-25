using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 問題產品下架階層查核_附件檔案
{
    public int 主鍵 { get; set; }

    public string? 案件編號 { get; set; }

    public int? 上下游商稽查表主鍵 { get; set; }

    public string? 案件階層 { get; set; }

    public string? 檔案名稱 { get; set; }

    public string? 檔案類型 { get; set; }

    public byte[]? 檔案內容 { get; set; }

    public string? 上傳人員 { get; set; }

    public DateTime? 上傳日期 { get; set; }
}
