using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核紀錄表_複方食品添加物紀錄
{
    public int 完成主鍵 { get; set; }

    public int 完成登錄查核主檔主鍵 { get; set; }

    public DateTime 記錄日期 { get; set; }

    /// <summary>
    /// 查核項目紀錄ID
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 登錄查核主檔ID
    /// </summary>
    public int 登錄查核主檔主鍵 { get; set; }

    /// <summary>
    /// 查核內容主類ID
    /// </summary>
    public string? 登錄查核內容主類主鍵 { get; set; }

    /// <summary>
    /// 查核內容次類ID
    /// </summary>
    public string? 登錄查核內容次類主鍵 { get; set; }

    /// <summary>
    /// 產品登錄碼
    /// </summary>
    public string? 產品登錄碼 { get; set; }

    /// <summary>
    /// 產品中文、英文名稱是否確實登錄
    /// </summary>
    public string? 產品中英文名稱是否確實登錄 { get; set; }

    /// <summary>
    /// 用途分類登錄符合情形
    /// </summary>
    public string? 用途分類登錄符合情形 { get; set; }

    /// <summary>
    /// 型態登錄符合情形
    /// </summary>
    public string? 型態登錄符合情形 { get; set; }

    /// <summary>
    /// 產品之成分資料登錄符合情形
    /// </summary>
    public string? 產品之成分資料登錄符合情形 { get; set; }

    /// <summary>
    /// 查驗登記資料與平台資料符合情形
    /// </summary>
    public string? 查驗登記資料與平台資料符合情形 { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 修改人員
    /// </summary>
    public string? 異動人員主鍵 { get; set; }

    /// <summary>
    /// 查核日期
    /// </summary>
    public DateTime? 查核稽查日期 { get; set; }
}
