using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢驗系統_檢驗成分代碼檔
{
    public Guid 主鍵 { get; set; }

    public string 代碼 { get; set; } = null!;

    public string 名稱 { get; set; } = null!;

    public string 名稱_列印用_ { get; set; } = null!;

    public string 成份_藥材_檢驗細項 { get; set; } = null!;

    public byte 是否為公告藥材 { get; set; }

    public byte 是否停用 { get; set; }

    public DateTime 建立時間 { get; set; }

    public DateTime 修改時間 { get; set; }

    public string? 藥證系統代碼 { get; set; }

    public string? 化學文摘社登記號碼 { get; set; }

    public string? 中文名稱 { get; set; }

    public string? 英文名稱 { get; set; }

    public Guid? 分類描述 { get; set; }

    public DateTime 最近PMDS轉入時間 { get; set; }

    public Guid PMDS系統編號 { get; set; }
}
