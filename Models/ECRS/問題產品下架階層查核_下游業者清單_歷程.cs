using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 問題產品下架階層查核_下游業者清單_歷程
{
    public int 主鍵 { get; set; }

    public int? 下游業者清單主鍵 { get; set; }

    public string? 案件編號 { get; set; }

    public int? 上下游商稽查表主鍵 { get; set; }

    public int? 層數 { get; set; }

    public string? 狀態 { get; set; }

    public string? 是否派案至非登 { get; set; }

    public DateTime? 派案日期 { get; set; }

    public string? 下游業者名稱 { get; set; }

    public string? 業者統一編號 { get; set; }

    public string? 業者食品登錄字號 { get; set; }

    public string? 下游業者縣市 { get; set; }

    public string? 下游業者鄉鎮 { get; set; }

    public string? 下游業者街道 { get; set; }

    public string? 下游業者地址 { get; set; }

    public DateTime? 出貨日期 { get; set; }

    public decimal? 售出下游量 { get; set; }

    public decimal? 下游退回量 { get; set; }

    public string? 關聯多產品主鍵 { get; set; }

    public string? 備註 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public DateTime? 非登_通知下游業者回收日期 { get; set; }

    public string? 業者代碼 { get; set; }

    public int? 業者序號 { get; set; }

    public string? 非登_下游業者主鍵 { get; set; }
}
