using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核紀錄表_單方食品添加物
{
    public int 主鍵 { get; set; }

    public int 登錄查核主檔主鍵 { get; set; }

    public string? 登錄查核內容主類主鍵 { get; set; }

    public string? 登錄查核內容次類主鍵 { get; set; }

    public string? 許可證標題名稱 { get; set; }

    public string? 許可證字號 { get; set; }

    public string? 產品登錄碼 { get; set; }

    public string? 查驗登記資料與平台資料符合情形 { get; set; }

    public string? 許可證有效日期是否逾期 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 查核稽查日期 { get; set; }
}
