using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案_自用源料查核資訊表
{
    public int 主鍵 { get; set; }

    public int? 專案名稱主鍵 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 醫事機構代碼 { get; set; }

    public DateTime? 發文日期 { get; set; }

    public string? 發文字號 { get; set; }

    public string? 自用源料申請商 { get; set; }

    public string? 原料藥品名稱 { get; set; }

    public string? 使用該原料藥之製造商名稱 { get; set; }

    public string? 供製造藥品之許可證字號 { get; set; }

    public string? 供製造藥品之中文品名 { get; set; }

    public int? 申請進口數量 { get; set; }

    public int? 季別 { get; set; }

    public string? 原料藥製造廠國名 { get; set; }

    public string? 原料藥製造廠名稱 { get; set; }

    public string? 原料藥製造廠地址_縣市 { get; set; }

    public string? 原料藥製造廠地址_區域 { get; set; }

    public string? 原料藥製造廠地址_地址 { get; set; }

    public string? 派案登記桌主鍵 { get; set; }

    public string? 稽查隊長主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
