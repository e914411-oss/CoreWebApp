using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_部門表
{
    /// <summary>
    /// 部門代碼
    /// </summary>
    public string 部門編號 { get; set; } = null!;

    /// <summary>
    /// 部門名稱
    /// </summary>
    public string? 名稱 { get; set; }

    /// <summary>
    /// 縣市代碼
    /// </summary>
    public string? 所在縣市編號 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 所屬區域
    /// </summary>
    public string? 所屬區域 { get; set; }

    /// <summary>
    /// 區域別  對應 Sys_Area.AreaId
    /// </summary>
    public int? 區域別 { get; set; }

    /// <summary>
    /// 停用
    /// </summary>
    public bool? 停用註記 { get; set; }

    public string? 對應身分證第一碼之英文 { get; set; }

    public bool? 是否有區隊長 { get; set; }

    public string? 管轄區管編號 { get; set; }

    public string? 機關代碼 { get; set; }
}
