using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處系統_主表
{
    public int 裁處系統主表編號 { get; set; }

    public int? 稽查類型 { get; set; }

    public int? 各稽查類型系統編號 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 處分機關名稱 { get; set; }

    public string? 處分機關編號 { get; set; }

    public string? 處分機關科室代碼 { get; set; }

    public string 行政處分_罰鍰 { get; set; } = null!;

    public string 行政處分_暫停具結放行 { get; set; } = null!;

    public string 行政處分_撤銷許可證 { get; set; } = null!;

    public string 行政處分_行政指導 { get; set; } = null!;

    public string 發文所屬機關代碼 { get; set; } = null!;

    public string 發文所屬科別代碼 { get; set; } = null!;

    public string 案件建立人員 { get; set; } = null!;

    public DateTime 案件建立日期 { get; set; }

    public string? 案件承辦人員 { get; set; }

    public string? 案件審查人員 { get; set; }

    public string? 案件管理人員 { get; set; }

    public string? 作業狀態 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 案件結案人員 { get; set; }

    public DateTime? 案件結案日期 { get; set; }

    public string? 案件異動人員 { get; set; }

    public DateTime? 案件異動日期 { get; set; }

    public string? 是否為移外縣市新增 { get; set; }

    public int? 移外事件記錄檔編號 { get; set; }

    public int? 稽查事件代碼 { get; set; }

    public string? 是否為裁處管理新增 { get; set; }

    public int? 舊裁處案件編號 { get; set; }

    public string? 衛生局主鍵 { get; set; }
}
