using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP不合格條文表紀錄
{
    public int 完成HACCP稽查主表主鍵 { get; set; }

    public DateTime 記錄日期 { get; set; }

    public int 完成主鍵 { get; set; }

    public int 主鍵 { get; set; }

    public int? HACCP稽查主表主鍵 { get; set; }

    public string? HACCP介接主鍵 { get; set; }

    public string? HACCP條文主鍵 { get; set; }

    public string? 備註 { get; set; }

    public byte[]? 照片檔案 { get; set; }

    public string? 照片檔案名稱 { get; set; }

    public string? HACCP查核重點 { get; set; }

    public string? 查驗結果 { get; set; }

    public string? 未使用 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
