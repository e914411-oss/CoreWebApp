using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒樣品檢驗檔
{
    /// <summary>
    /// 檢體抽驗代碼
    /// </summary>
    public int 樣品檢驗檔_主鍵 { get; set; }

    /// <summary>
    /// 檢體類別代碼
    /// </summary>
    public int? 樣品種類 { get; set; }

    /// <summary>
    /// 檢體代碼
    /// </summary>
    public int? 樣品細項 { get; set; }

    /// <summary>
    /// 件數
    /// </summary>
    public int? 樣品數量 { get; set; }

    /// <summary>
    /// 採樣日期
    /// </summary>
    public DateTime? 檢驗日期 { get; set; }

    /// <summary>
    /// 前調理方式
    /// </summary>
    public string? 樣品烹調方式 { get; set; }

    /// <summary>
    /// 運送保存方式
    /// </summary>
    public string? 樣品儲存方式 { get; set; }

    /// <summary>
    /// 填報人員
    /// </summary>
    public string? 回報人員 { get; set; }

    /// <summary>
    /// 聯絡電話
    /// </summary>
    public string? 電話 { get; set; }

    /// <summary>
    /// 分機
    /// </summary>
    public string? 分機 { get; set; }

    /// <summary>
    /// 檢體單位
    /// </summary>
    public string? 樣品_部門 { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? 備註 { get; set; }
}
