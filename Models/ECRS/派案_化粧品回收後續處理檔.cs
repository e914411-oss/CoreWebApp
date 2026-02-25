using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案_化粧品回收後續處理檔
{
    public int 系統識別碼 { get; set; }

    public int 專案代碼 { get; set; }

    public int 回收主檔代碼 { get; set; }

    public string 負責衛生局代碼 { get; set; } = null!;

    public string? 稽查區域編號 { get; set; }

    public string? 承辦人員編號 { get; set; }

    public int? 業者代碼 { get; set; }

    public bool 是否可用 { get; set; }

    public DateTime 新增時間 { get; set; }

    public string 新增人員 { get; set; } = null!;

    public DateTime 更新時間 { get; set; }

    public string 更新人員 { get; set; } = null!;
}
