using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢驗系統檢驗成份代碼檔
{
    public int 系統編號 { get; set; }

    public string? 檢驗系統_檢驗成分編號 { get; set; }

    public string? 檢驗系統_檢驗成分名稱 { get; set; }

    public bool? 狀態 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 更新日期 { get; set; }

    public string? 更新人員 { get; set; }
}
