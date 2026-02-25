using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 病人用特殊營養食品查驗登記
{
    public int 特殊食物流水編號 { get; set; }

    public string? 公司名稱 { get; set; }

    public string? 中文名稱 { get; set; }

    public string? 英文名稱 { get; set; }

    public string? 工廠名稱 { get; set; }

    public string? 相關規格 { get; set; }

    public string? 相關圖片 { get; set; }

    public string? 其他相關資訊 { get; set; }

    public string? 獲得這筆資料日期 { get; set; }

    public string? 取得日期 { get; set; }

    public string? 第一筆訂單 { get; set; }

    public string? 最後一筆訂單 { get; set; }

    public string? 電話號碼 { get; set; }

    public string? 地址 { get; set; }

    public string? 縣市 { get; set; }

    public string? 相關附錄 { get; set; }

    public int? 狀態 { get; set; }

    public int? 種類 { get; set; }

    public string? 地點 { get; set; }
}
