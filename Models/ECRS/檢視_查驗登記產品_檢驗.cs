using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_查驗登記產品_檢驗
{
    public int 查驗登記產品查核明細表主鍵 { get; set; }

    public string? 縣市主鍵 { get; set; }

    public int? 業者主鍵 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 國曆稽查日期 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

    public int? 市招名稱 { get; set; }

    public string? 查驗登記產品中文名稱 { get; set; }

    public string? 許可證字號 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員主鍵 { get; set; }

    public string? 查核項目_保健功效成分含量符合性 { get; set; }

    public string? 查核項目_營養素含量符合性 { get; set; }

    public string? 查核項目_衛生標準符合性 { get; set; }

    public string? 查驗登記產品類型代碼 { get; set; }
}
