using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品保健功效成分檢驗結果表紀錄
{
    public int 紀錄主鍵 { get; set; }

    public int? 完成查驗登記產品查核明細表主鍵 { get; set; }

    public int? 主鍵 { get; set; }

    public int? 查驗登記產品查核明細表主鍵 { get; set; }

    public string? 保健功效成分 { get; set; }

    public string? 檢測值 { get; set; }

    public string? 標示值 { get; set; }

    public string? 合格與否 { get; set; }

    public string? 產品類型代碼 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public int? 前次完成查驗登記產品查核明細表主鍵 { get; set; }
}
