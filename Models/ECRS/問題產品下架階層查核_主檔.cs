using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 問題產品下架階層查核_主檔
{
    public int 主鍵 { get; set; }

    public string 案件編號 { get; set; } = null!;

    public string? 協辦單位部門 { get; set; }

    public string? 協辦單位部門_名稱 { get; set; }

    public string? 回收原因 { get; set; }

    /// <summary>
    /// 抽驗稽查-違反法條
    /// </summary>
    public string? 違反法條 { get; set; }

    public string? 違反法條_名稱 { get; set; }

    /// <summary>
    /// 抽驗稽查-其他法律
    /// </summary>
    public string? 違反法條_其他法律說明 { get; set; }

    public string? 業者代碼 { get; set; }

    public int? 業者序號 { get; set; }

    public string? 業者名稱 { get; set; }

    public string? 業者統一編號 { get; set; }

    public string? 業者食品登錄字號 { get; set; }

    public string? 業者縣市 { get; set; }

    public string? 業者鄉鎮 { get; set; }

    public string? 業者街道 { get; set; }

    public string? 狀態 { get; set; }

    public string? 是否派案至非登 { get; set; }

    public DateTime? 派案日期 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateTime? 結案日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 縣市代碼 { get; set; }
}
