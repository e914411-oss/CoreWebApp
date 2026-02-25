using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核項目紀錄表
{
    public int 主鍵 { get; set; }

    public int 登錄查核主檔主鍵 { get; set; }

    public int 登錄查核項目主類主鍵 { get; set; }

    public int 登錄查核項目次類主鍵 { get; set; }

    public string? 查核結果代碼 { get; set; }

    public string? 不符合事項說明 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 國曆限期改善日期 { get; set; }

    public string? 其他 { get; set; }

    public string? 現場稽查結果 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
