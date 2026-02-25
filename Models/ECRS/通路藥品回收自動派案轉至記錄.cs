using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 通路藥品回收自動派案轉至記錄
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int 系統編號 { get; set; }

    /// <summary>
    /// DRG8001_VIEW. ID
    /// </summary>
    public int? 藥品重大品質事件序號 { get; set; }

    /// <summary>
    /// drg8001_view.applNO
    /// </summary>
    public string? 藥品重大品質事件案件編號 { get; set; }

    /// <summary>
    /// drg8001_view. postDate
    /// </summary>
    public string? 發文日期 { get; set; }

    /// <summary>
    /// drg8001_view. postNo
    /// </summary>
    public string? 發文字號 { get; set; }

    /// <summary>
    /// drg8001_view. chProduct
    /// </summary>
    public string? 藥品品名 { get; set; }

    /// <summary>
    /// 許可證字號
    /// </summary>
    public string? 許可證字號 { get; set; }

    /// <summary>
    /// drg8001_view. appName
    /// </summary>
    public string? 許可證持有者 { get; set; }

    /// <summary>
    /// drg8001_view. manufactorName
    /// </summary>
    public string? 製造廠 { get; set; }

    /// <summary>
    /// drg8001_view. orirecyclereason
    /// </summary>
    public string? 回收原因 { get; set; }

    /// <summary>
    /// con0001_view. id
    /// </summary>
    public int? 檔案編號 { get; set; }

    /// <summary>
    /// con0001_view. filename
    /// </summary>
    public string? 檔案名稱 { get; set; }

    /// <summary>
    /// 例：檔案格式不對、xxx欄位未提供...等
    /// </summary>
    public string? 轉至記錄 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }
}
