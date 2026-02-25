using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記工廠條文代碼表
{
    public int 主鍵 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    public string? 查驗登記工廠類型代碼 { get; set; }

    public string? 條款內容 { get; set; }

    public int? 編號_1 { get; set; }

    public int? 編號_2 { get; set; }

    public bool? 是否為標題 { get; set; }

    public int? 符合性要求嚴格度判定參考 { get; set; }

    public bool? 文件審查 { get; set; }

    public bool? 現場查驗 { get; set; }

    /// <summary>
    /// 是否啟用
    /// </summary>
    public string? 是否啟用 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
