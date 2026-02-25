using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒縣市轉移表
{
    public int 食品中毒縣市轉移表_主鍵 { get; set; }

    /// <summary>
    /// 案件編號
    /// </summary>
    public int 食品中毒速報主表主鍵 { get; set; }

    /// <summary>
    /// 主辦城市代碼
    /// </summary>
    public string? 主案縣市id { get; set; }

    /// <summary>
    /// 協辦城市代碼
    /// </summary>
    public string? 協辦縣市id { get; set; }

    /// <summary>
    /// 協辦城市名稱
    /// </summary>
    public string? 協辦縣市名稱 { get; set; }

    /// <summary>
    /// 主檔權限
    /// </summary>
    public int? 主檔權限 { get; set; }

    /// <summary>
    /// 攝食人員權限
    /// </summary>
    public int? 攝食人員權限 { get; set; }

    /// <summary>
    /// 攝食場所權限
    /// </summary>
    public int? 攝食場所權限 { get; set; }

    /// <summary>
    /// 檢驗權限
    /// </summary>
    public int? 檢驗權限 { get; set; }

    /// <summary>
    /// 使用狀態
    /// </summary>
    public string? 使用狀態 { get; set; }

    public string? FMS介接主鍵 { get; set; }
}
