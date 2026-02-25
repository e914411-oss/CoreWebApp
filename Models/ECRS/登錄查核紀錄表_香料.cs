using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核紀錄表_香料
{
    public int 主鍵 { get; set; }

    public int 登錄查核主檔主鍵 { get; set; }

    public string? 登錄查核內容主類主鍵 { get; set; }

    public string? 登錄查核內容次類主鍵 { get; set; }

    public string? 產品登錄碼 { get; set; }

    public string? 產品中英文名稱是否確實登錄 { get; set; }

    public string? 如有香料風味分類登錄情形 { get; set; }

    public string? 型態登錄符合情形 { get; set; }

    public string? 產品之成分資料登錄符合情形 { get; set; }

    public string? 如有查驗登記資料與平台資料符合情形 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 查核稽查日期 { get; set; }
}
