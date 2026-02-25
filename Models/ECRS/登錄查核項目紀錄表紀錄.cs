using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核項目紀錄表紀錄
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
    /// 查核項目主類ID
    /// </summary>
    public int 登錄查核項目主類主鍵 { get; set; }

    /// <summary>
    /// 查核項目次類ID
    /// </summary>
    public int 登錄查核項目次類主鍵 { get; set; }

    /// <summary>
    /// 查核結果ID
    /// </summary>
    public string? 查核結果代碼 { get; set; }

    /// <summary>
    /// 不符合事項說明
    /// </summary>
    public string? 不符合事項說明 { get; set; }

    /// <summary>
    /// 稽查結果代碼
    /// </summary>
    public string? 稽查結果代碼 { get; set; }

    /// <summary>
    /// 稽查結果
    /// </summary>
    public string? 稽查結果 { get; set; }

    /// <summary>
    /// 限期改善
    /// </summary>
    public string? 國曆限期改善日期 { get; set; }

    /// <summary>
    /// 其他
    /// </summary>
    public string? 其他 { get; set; }

    /// <summary>
    /// 現場稽查結果
    /// </summary>
    public string? 現場稽查結果 { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 修改人員
    /// </summary>
    public string? 異動人員主鍵 { get; set; }
}
