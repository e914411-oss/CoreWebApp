using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 邊境抽驗不合格後市場回報_無庫存下游派案
{
    public int 主鍵 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 商業登記地址 { get; set; }

    public int? 派案來源主案主鍵 { get; set; }

    public string 主案_報驗案號 { get; set; } = null!;

    public string? 業者名稱 { get; set; }

    public DateTime? 資料建立日期 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 稽查結果_併前案_報驗案號 { get; set; }

    public string? 稽查結果_衛生局檢驗不合格_報驗案號 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 稽查日期_時 { get; set; }

    public string? 稽查日期_分 { get; set; }

    public string? 稽查日期_國曆 { get; set; }

    public string? 異動人員編號 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 刪除原因 { get; set; }

    public string? 備註 { get; set; }

    public string? 檢驗不合格辦理情形 { get; set; }

    public DateTime? 回報日期 { get; set; }

    public string? 管理參考 { get; set; }

    public DateTime? 報告日期 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 回收情形 { get; set; }

    public DateTime? 派案寄信日 { get; set; }
}
